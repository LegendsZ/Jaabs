using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Backend
{
    internal class AccountDetails
    {
        public string CustomerNumber { get; set; }
        public Card Chequing { get; set; }
        public Card Savings { get; set; }
        public AccountDetails(string customerNumber, Card chequing, Card savings)
        {
            CustomerNumber = customerNumber;
            Chequing = chequing;
            Savings = savings;
        }
        public bool Match(string number)
        {
            return CustomerNumber.Equals(number);
        }
        public double TotalCash()
        {
            double totalCash = 0;
            if (Chequing != null) totalCash += Chequing.Cash;
            if (Savings != null) totalCash += Savings.Cash;
            return totalCash;
        }
    }
}
