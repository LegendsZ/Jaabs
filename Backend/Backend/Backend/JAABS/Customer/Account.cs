using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    internal class Account
    { 
        public string Type { get; set; }
        public int TransitNumber { get; set; }
        public int InsitutionNumber { get; set; }
        public int AccountNumber { get; set; }
        public double Cash { get; set; }
        public Account(string type, int transitnumber, int institutionnumber, int accountnumber, double cash)
        {
            Type = type;
            TransitNumber = transitnumber;
            InsitutionNumber = institutionnumber;
            AccountNumber = accountnumber;
            Cash = cash;
        }
    }
}
