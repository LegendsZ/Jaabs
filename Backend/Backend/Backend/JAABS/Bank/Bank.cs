﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Default bank format
namespace JAABS.Bank
{
    internal class Bank
    {
        public string Name { get; set; }
        public JAABS.Customer.Customer[] Customers { get; set; }
        public JAABS.Bank.Hash[] Hashes { get; set; }
        public string CustomerServer;
        public Bank(string name, string customersFile, string hashFile)
        {
            Name = name;
            CustomerServer = customersFile;
            Customers = CustomerReader(customersFile);
            Hashes = HashReader(hashFile);
        }

        public int VerifyLogin(string cardNumber, string pin)
        {
            string hash = JAABS.Encryptioner.EncryptPin(JAABS.Encryptioner.DecryptKey(pin));
            cardNumber = JAABS.Encryptioner.DecryptKey(cardNumber);
            JAABS.Customer.Customer temp = customerFinder(cardNumber);
            //"if (hash == "efgh") return true;"
            if (HashFinder(cardNumber) != hash)
            {
                temp.Attempts += 1;
                if (temp.Attempts >= 3) temp.Blocked = true;
                UpdateServer();
                return 1;
            }
            if (temp.Blocked == true) return 2;
            return 0;
        }
        //Blocks account if deposit is more than 10k (Not legal)
        public bool requestDeposit(string cardNumber, int amount, string where)
        {
            JAABS.Customer.Customer temp = customerFinder(JAABS.Encryptioner.DecryptKey(cardNumber));
            if (where == "savings")
            {
                temp.Savings.Cash += amount;
            }
            else
            {
                temp.Chequing.Cash += amount;
            }
            if (amount >= 10000)
            {
                temp.Blocked = true;
                return false;
            }


            return true;
        }
        public JAABS.Customer.Customer[] CustomerReader(string customerFile)
        {
            //stores the lines of data in the file into elements of an array
            string[] lines = File.ReadAllLines(customerFile);
            //customer array with the size of the number of customers in the file
            JAABS.Customer.Customer[] customers = new JAABS.Customer.Customer[lines.Length];
            int count = 0;

            //iterates through each customer's data
            foreach (string line in lines)
            {
                //seperate the data into an array
                string[] token = line.Split(',');

                //creates the customer's chequing account
                JAABS.Customer.Account chequing = new JAABS.Customer.Account(token[3], Int32.Parse(token[4]), Int32.Parse(token[5]), Int32.Parse(token[6]), Convert.ToDouble(token[7]));

                //creates the customer's saving account
                JAABS.Customer.Account saving = new JAABS.Customer.Account(token[8], Int32.Parse(token[9]), Int32.Parse(token[10]), Int32.Parse(token[11]), Convert.ToDouble(token[12]));

                //creates the customer's credit card account
                JAABS.Customer.Account atm = new JAABS.Customer.Account(token[13], Int32.Parse(token[14]), Int32.Parse(token[15]), Int32.Parse(token[16]), Convert.ToDouble(token[17]));
                //adds the customer to the array
                customers[count] = new JAABS.Customer.Customer(token[0], Int32.Parse(token[1]), token[2], chequing, saving, atm, token[18], Int32.Parse(token[19]), Int32.Parse(token[20]));
                count++;
            }

            return customers;
        }

        public JAABS.Bank.Hash[] HashReader(string hashFile)
        {
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
            Console.WriteLine("Card Number: {0}", cardNumber);
            cardNumber = JAABS.Encryptioner.DecryptKey(cardNumber);
            Console.WriteLine("Card Number: {0}", cardNumber);
            JAABS.Customer.Customer temp = customerFinder(cardNumber);
            if (temp == null)
            {
                Console.WriteLine("Wow");
            }
            if (type == "1")
            {
                if (temp.Chequing.Cash > amount)
                {
                    temp.Chequing.Cash = temp.Chequing.Cash - amount;
                    return true;
                }
            }
            if (type == "2")
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
                return true;
            }
            return false;
            UpdateServer();
        }
        public void depositCheque(JAABS.Bank.Cheque toDeposit, string cardNumber,string choice)
        {
            foreach (JAABS.Customer.Customer cust in Customers)
            {
                if (cust.CardNumber.Equals(cardNumber))
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