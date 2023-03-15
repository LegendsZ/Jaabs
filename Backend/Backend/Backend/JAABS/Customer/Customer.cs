using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public AccountDetails Account { get; set; }

        public Customer(string name, int age, string address, AccountDetails account)
        {
            Name = name;
            Age = age;
            Address = address;
            Account = account;
        }
    }
}
