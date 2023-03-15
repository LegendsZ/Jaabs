using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Backend
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Accountdetails Account { get; set; }

        public Customer(string name, int age, string address, AccountDetails account)
        {
            Name = name;
            Age = age;
            Address = address;
            Account = account;
        }
    }
}
