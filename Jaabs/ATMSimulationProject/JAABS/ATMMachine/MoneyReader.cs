using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Money reader
namespace JAABS.ATMMachine
{
    internal class MoneyReader
    {
        //Read all money from txt
        public static int Read()
        {
            string money = System.IO.File.ReadAllText("MoneyReader.txt");
            Eject();
            return Convert.ToInt32(money);
        }

        //Eject card
        public static void Eject()
        {
            System.IO.File.WriteAllText("MoneyReader.txt", "");
        }
    }
}
