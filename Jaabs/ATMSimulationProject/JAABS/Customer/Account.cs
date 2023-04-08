using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//account class
namespace JAABS.Customer
{
    public class Account
    { 
        //account variables
        public string Type { get; set; }
        public string TransitNumber { get; set; }
        public string InsitutionNumber { get; set; }
        public string AccountNumber { get; set; }
        public double Cash { get; set; }

        //Intialize account object
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
