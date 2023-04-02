using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Default bank format
namespace JAABS.Bank
{
    public class Bank
    {
        public string Name { get; set; }
        public JAABS.Customer.Customer[] Customers { get; set; }
        public JAABS.Bank.Hash[] Hashes { get; set; }
        public string CustomerServer;
        public Bank(string name, string customersFile, string hashFile)
        {
            Name = name;
            CustomerServer = customersFile;
            Customers = CustomerReader(customersFile,"payees.txt");
            Hashes = HashReader(hashFile);
        }

        public int VerifyLogin(string cardNumber, string pin)
        {
            string hash = JAABS.Encryptioner.EncryptPin(JAABS.Encryptioner.DecryptKey(pin));
            cardNumber = JAABS.Encryptioner.DecryptKey(cardNumber);
            JAABS.Customer.Customer temp = customerFinder(cardNumber);
            //Return: 0 for approved login, 1 for blocked account, 2 for wrong pin
            if (HashFinder(cardNumber) != hash)
            {
                temp.Attempts += 1;
                if (temp.Attempts >= 3) temp.Blocked = 1;
                UpdateServer();
                return 1;
            }
            if (temp.Blocked == 1)
            {
                temp.Attempts = 0;
                return 2;
            };
            return 0;
        }
        //Blocks account if deposit is more than 10k (Not legal)
        public bool requestDeposit(string cardNumber, int amount, string where)
        {
            JAABS.Customer.Customer temp = customerFinder(JAABS.Encryptioner.DecryptKey(cardNumber));
            if (where == "Savings")
            {
                temp.Savings.Cash += amount;
            }
            else
            {
                temp.Chequing.Cash += amount;
            }
            if (amount >= 10000)
            {
                temp.Blocked = 1;
                return false;
            }
            UpdateServer();
            return true;
        }
        public String RequestBalance(string cardNumber, string choice)
        {
            JAABS.Customer.Customer temp = customerFinder(cardNumber);
            if (choice == "Savings")
            {
                return String.Format("{0:0.00}", temp.Savings.Cash);
            }
            return String.Format("{0:0.00}", temp.Chequing.Cash);
        }
        public bool payPayee(JAABS.Customer.Customer cust, int amount)
        {
            foreach (JAABS.Customer.Customer tcust in Customers)
            {
                if (tcust.CardNumber.Equals(cust.CardNumber))
                {
                    tcust.Chequing.Cash += amount;
                    UpdateServer();
                    return true;
                }
            }
            return false;
        }
        public JAABS.Customer.Customer[] CustomerReader(string customerFile,string payeeFile)
        {
            //Stores the lines of data in the file into elements of an array
            string[] lines = File.ReadAllLines(customerFile);
            //Customer array with the size of the number of customers in the file
            JAABS.Customer.Customer[] customers = new JAABS.Customer.Customer[lines.Length];
            int count = 0;

            String[] payeeLines = System.IO.File.ReadAllLines(payeeFile);

            //iterates through each customer's data
            foreach (string line in lines)
            {
                //Separate the data into an array
                string[] token = line.Split(',');

                //Creates the customer's chequing account
                JAABS.Customer.Account chequing = new JAABS.Customer.Account(token[3], token[4], token[5], token[6], Convert.ToDouble(token[7]));

                //Creates the customer's saving account
                JAABS.Customer.Account saving = new JAABS.Customer.Account(token[8], token[9], token[10], token[11], Convert.ToDouble(token[12]));

                //Creates the customer's credit card account
                JAABS.Customer.Account atm = new JAABS.Customer.Account(token[13], token[14], token[15], token[16], Convert.ToDouble(token[17]));
                //Adds the customer to the array
                customers[count] = new JAABS.Customer.Customer(token[0], Int32.Parse(token[1]), token[2], chequing, saving, atm, token[18], Int32.Parse(token[19]), Int32.Parse(token[20]));
                count++;
            }

            int custID = 0;
            foreach (string payeeLine in payeeLines)
            {
                string[] payeees = payeeLine.Split(',');
                foreach (string word in payeees)
                {
                    string[] indivPayee = word.Split(':');
                    //0th element will be name
                    //1st element will be cardnumber
                    int index = -1;
                    for (int i = 0; i < customers.Length; i++)
                    {
                        if (customers[i].CardNumber.Equals(indivPayee[1]))
                        {
                            index = i;
                            break;
                        }
                    }
                    if (index != -1) //error handle maybe but unncessary since we make assumption payee is always known.
                    {
                        customers[custID].payees.Add(new JAABS.Customer.Payee(customers[index], indivPayee[0]));
                    }
                }
                custID++;
            }

            return customers;
        }

        public JAABS.Bank.Hash[] HashReader(string hashFile)
        {
            //Access the server (textfile) of hashes and save them (for quick access)
            string[] lines = File.ReadAllLines(hashFile);
            JAABS.Bank.Hash[] hashes = new JAABS.Bank.Hash[lines.Length];
            int count = 0;

            foreach (string line in lines)
            {
                string[] token = line.Split(',');
                hashes[count] = new Hash(token[0], token[1]);
                count++;
            }

            return hashes;
        }

        public string HashFinder(string cardNumber)
        {
            for (int i = 0; i < Hashes.Length; i++)
            {
                if (Hashes[i].CardNumber == cardNumber)
                {
                    return Hashes[i].HashString;
                }
            }
            return null;
        }

        public JAABS.Customer.Customer customerFinder(string cardNumber)
        {
            for (int i = 0; i < Customers.Length; i++)
            {
                if (Customers[i].CardNumber == cardNumber)
                {
                    Console.WriteLine("Customer: {0}", Customers[i].Name);
                    return Customers[i];
                }
            }
            return null;
        }

        public bool requestWithdraw(string cardNumber, int amount, string type)
        {
            cardNumber = JAABS.Encryptioner.DecryptKey(cardNumber);
            JAABS.Customer.Customer temp = customerFinder(cardNumber);
            if (temp == null)
            {
                Console.WriteLine("Wow");
            }
            if (type == "Chequing")
            {
                if (temp.Chequing.Cash > amount)
                {
                    temp.Chequing.Cash = temp.Chequing.Cash - amount;
                    UpdateServer();
                    return true;
                }
            }
            if (type == "Savings")
            {
                if (temp.Savings.Cash > amount)
                {
                    temp.Savings.Cash = temp.Savings.Cash - amount;
                    UpdateServer();
                    return true;
                }
            }
            UpdateServer();
            return false;
        }

        public bool orderCash(string cardNumber, int amount)
        {
            cardNumber = JAABS.Encryptioner.DecryptKey(cardNumber);
            JAABS.Customer.Customer temp = customerFinder(cardNumber);
            if (temp.Credit.Cash - amount > -10000)
            {
                temp.Credit.Cash = temp.Credit.Cash - amount;
                UpdateServer();
                return true;
            }
            UpdateServer();
            return false;
        }
        public void depositCheque(JAABS.Bank.Cheque toDeposit, string cardNumber,string choice)
        {
            foreach (JAABS.Customer.Customer cust in Customers)
            {
                if (cust.CardNumber.Equals(Encryptioner.DecryptKey(cardNumber)))
                {
                    if (choice.Equals("savings"))
                    {
                        cust.Savings.Cash += toDeposit.amount;
                    }
                    else //we know it'll be one of the two
                    {
                        cust.Chequing.Cash += toDeposit.amount;
                    }
                }
            }
            UpdateServer();
        }
        public void UpdateServer()
        {
            //Rewrites all data in the server (textfile)
            string[] CustomersData = new string[Customers.Length];
            JAABS.Customer.Customer temp;
            for (int i = 0; i < Customers.Length; i++)
            {
                temp = Customers[i];
                string customerData = $"{temp.Name},{temp.Age},{temp.Address},{temp.Chequing.Type},{temp.Chequing.TransitNumber},{temp.Chequing.InsitutionNumber},{temp.Chequing.AccountNumber},{temp.Chequing.Cash},{temp.Savings.Type},{temp.Savings.TransitNumber},{temp.Savings.InsitutionNumber},{temp.Savings.AccountNumber},{temp.Savings.Cash},{temp.Credit.Type},{temp.Credit.TransitNumber},{temp.Credit.InsitutionNumber},{temp.Credit.AccountNumber},{temp.Credit.Cash},{temp.CardNumber},{temp.Blocked},{temp.Attempts}";
                CustomersData[i] = customerData;
            }
            File.WriteAllLines(CustomerServer, CustomersData);
        }
    }
}
