using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hash class
namespace JAABS.Bank
{
    public class Hash
    {
        //Vaibles card number and hash
        public string CardNumber { get; set; }
        public string HashString { get; set; }

        //Get has and card number
        public Hash (string cardNumber, string hashString)
        {
            CardNumber = cardNumber;
            HashString = hashString;
        }
    }
}
