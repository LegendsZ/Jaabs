using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.Customer
{
    internal class Customer
    {
        public string m_name { get; set; }
        public int m_age { get; set; }
        public string m_address { get; set; }
        public Account m_chequing { get; set; }
        public Account m_savings { get; set; }

        public double TotalCash()
        {
            double totalCash = 0;
            if (m_chequing != null) totalCash += m_chequing.m_cash;
            if (m_savings != null) totalCash += m_savings.m_cash;
            return totalCash;
        }


        public Customer(string name, int age, string address, Account chequing, Account savings)
        {
            m_name = name;
            m_age = age;
            m_address = address;
            m_chequing = chequing;
            m_savings = savings;
        }
    }
}
