using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Account Chequing { get; set; }
        public Account Savings { get; set; }
        public Account Credit { get; set; }

        public List<Payee> payees = new List<Payee>();
        public string CardNumber { get; set; }
        public int Blocked { get; set; }
        public int Attempts { get; set; }

        public double TotalCash()
        {
            double totalCash = 0;
            if (Chequing != null) totalCash += Chequing.Cash;
            if (Savings != null) totalCash += Savings.Cash;
            return totalCash;
        }

        public Customer(string name, int age, string address, Account chequing, Account savings, Account credit, string cardNumber, int status, int attempts)
        {
            Name = name;
            CardNumber = cardNumber;
            Age = age;
            Address = address;
            Chequing = chequing;
            Savings = savings;
            Credit = credit;
            Blocked = status;
            Attempts = attempts;
        }
    }
}
