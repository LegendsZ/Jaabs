using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Backend
{
    internal class Card
    { 
        public string Type { get; set; }
        public int TransitNumber { get; set; }
        public int InstitutionNumber { get; set; }
        public int AccountNumber { get; set; }
        public double Cash { get; set; }
        public Card(string type, int transitnumber, int institutionnumber, int accountnumber, double cash)
        {
            Type = type;
            TransitNumber = transitnumber;
            InstitutionNumber = institutionnumber;
            AccountNumber = accountnumber;
            Cash = cash;
        }
    }
}
