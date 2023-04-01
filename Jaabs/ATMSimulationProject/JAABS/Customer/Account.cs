using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    public class Account
    { 
        public string Type { get; set; }
        public string TransitNumber { get; set; }
        public string InsitutionNumber { get; set; }
        public string AccountNumber { get; set; }
        public double Cash { get; set; }
        public Account(string type, string transitnumber, string institutionnumber, string accountnumber, double cash)
        {
            Type = type;
            TransitNumber = transitnumber;
            InsitutionNumber = institutionnumber;
            AccountNumber = accountnumber;
            Cash = cash;
        }
    }
}
