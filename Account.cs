using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulationProject.models
{
    public class Account
    {
        public long accountNumber { get; set; }

        public long PIN { get; set; } 
        public decimal Balance { get; set; }

        public string FullName { get; set; }

        public Account(long accountNumber, long pIN, decimal balance, string fullName)
        {
            this.accountNumber = accountNumber;
            PIN = pIN;
            Balance = balance;
            FullName = fullName;
        }

        new public string ToString()
        {
            return FullName;
        }

    }
}
