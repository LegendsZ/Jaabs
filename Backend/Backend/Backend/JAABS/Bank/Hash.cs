using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Bank
{
    internal class Hash
    {
        public string CustomerID { get; set; }
        public string HashString { get; set; }

        public Hash (string customerID, string hashString)
        {
            CustomerID = customerID;
            HashString = hashString;
        }
    }
}
