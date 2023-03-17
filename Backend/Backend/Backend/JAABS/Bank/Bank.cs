using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Default bank format
namespace JAABS.Bank
{
    internal class Bank
    {
        public string Name { get; set; }
        public JAABS.Customer.Customer[] Customers { get; set; }
        public JAABS.Bank.Hash[] Hashes { get; set; }
        public Bank(string name, string customersFile, string hashFile)
        {
            Name = name;
            //Customers = customersFile.read();
            Customers = new JAABS.Customer.Customer[] {};
            //Hashes = hashFile.read();
            Hashes = new JAABS.Bank.Hash[] {};
        }

        public bool VerifyLogin(string cardNumber, string hash)
        {

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
                Account chequing = new Account(token[3], Int32.Parse(token[4]), Int32.Parse(token[5]), Int32.Parse(token[6]), Convert.ToDouble(token[7]));

                //creates the customer's saving account
                Account saving = new Account(token[8], Int32.Parse(token[9]), Int32.Parse(token[10]), Int32.Parse(token[11]), Convert.ToDouble(token[12]));

                //adds the customer to the array
                customers[count] = new JAABS.Customer.Customer(token[0], Int32.Parse(token[1]), token[2], chequing, saving);

                count++;
            }

            return customers;
        }
    }
}
