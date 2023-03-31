using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.ATMMachine
{
    internal class MoneyReader
    {
        public static int Read()
        {
            string money = System.IO.File.ReadAllText("MoneyReader.txt");
            Eject();
            return Convert.ToInt32(money);
        }

        public static void Eject()
        {
            System.IO.File.WriteAllText("MoneyReader.txt", "");
        }
    }
}
