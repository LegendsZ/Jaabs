using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    internal class Account
    { 
        public string m_type { get; set; }
        public int m_transitNumber { get; set; }
        public int m_institutionNumber { get; set; }
        public int m_accountNumber { get; set; }
        public double m_cash { get; set; }
        public Account(string type, int transitnumber, int institutionnumber, int accountnumber, double cash)
        {
            m_type = type;
            m_transitNumber = transitnumber;
            m_institutionNumber = institutionnumber;
            m_accountNumber = accountnumber;
            m_cash = cash;
        }
    }
}
