using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    internal class Payee
    {
        public JAABS.Customer.Customer cust;
        public string name;
        public Payee(Customer cust, string name)
        {
            this.cust = cust;
            this.name = name;
        }


        public string toString()
        {
            string censoredCardNumber = "";
            for (int i = 0; i < cust.CardNumber.Length; i++)
            {
                if (i < cust.CardNumber.Length - 4)
                {
                    censoredCardNumber += "*";
                }
                else
                {
                    censoredCardNumber += cust.CardNumber[i];
                }
            }
            return name + " " + censoredCardNumber;
        }
    }
}
