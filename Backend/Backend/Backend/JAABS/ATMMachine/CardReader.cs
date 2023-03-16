using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.ATMMachine
{
    internal class CardReader
    {
        public static string Read()
        {
            string cardNumber = System.IO.File.ReadAllText("CardReader.txt");
            return cardNumber;
        }

        public static void Eject()
        {
            System.IO.File.WriteAllText("CardReader.txt", "");
        }
    }
}
