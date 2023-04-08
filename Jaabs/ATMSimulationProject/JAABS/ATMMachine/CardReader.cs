using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Card reader
namespace JAABS.ATMMachine
{
    internal class CardReader
    {
        //Read the card from txt
        public static string Read()
        {
            string cardNumber = System.IO.File.ReadAllText("CardReader.txt");
            return cardNumber;
        }

        //Eject current card
        public static void Eject()
        {
            System.IO.File.WriteAllText("CardReader.txt", "");
        }
    }
}
