using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Bank
{
    public class Cheque
    {
        public string ChequeNumber;
        public string TransitNumber;
        public string FinancialInstNumber;
        public string AccountNumber;
        public string sender;
        public string receiver;
        public int amount;
        public Cheque(string ChequeNumber, string TransitNumber, string FinancialInstNumber, string AccountNumber, string sender, string receiver, int amount)
        {
            this.ChequeNumber = ChequeNumber;
            this.TransitNumber = TransitNumber;
            this.FinancialInstNumber = FinancialInstNumber;
            this.AccountNumber = AccountNumber;
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
        }
    }
}
