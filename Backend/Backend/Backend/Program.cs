using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Jaabs Backend";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello World!\n");

        JAABS.Customer.Customer roland = new JAABS.Customer.Customer("Roland", 69, "Somewhere in Toronto", new JAABS.Customer.Account("Chequing", 123, 123, 123, 10), null);
        Console.WriteLine("Customer: {0}\nAddress: {1}\nAge: {2}\nTotal Cash: {3}", roland.m_name, roland.m_address, roland.m_age, roland.TotalCash());

        Console.ReadKey(); //waits for keyinput
    }
}
