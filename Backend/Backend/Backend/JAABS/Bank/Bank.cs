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
    }
}
