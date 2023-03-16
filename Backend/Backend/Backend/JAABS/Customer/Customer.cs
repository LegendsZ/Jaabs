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
        public Account Chequing { get; set; }
        public Account Savings { get; set; }

        public double TotalCash()
        {
            double totalCash = 0;
            if (Chequing != null) totalCash += Chequing.m_cash;
            if (Savings != null) totalCash += Savings.m_cash;
            return totalCash;
        }


        public Customer(string name, int age, string address, Account chequing, Account savings)
        {
            Name = name;
            Age = age;
            Address = address;
            Chequing = chequing;
            Savings = savings;
        }
    }
}
