using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Bank
{
    internal class Hash
    {
        public string CardNumber { get; set; }
        public string HashString { get; set; }

        public Hash (string cardNumber, string hashString)
        {
            CardNumber = cardNumber;
            HashString = hashString;
        }
    }
}
