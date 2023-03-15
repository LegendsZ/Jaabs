using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jaabs Backend";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!\n");

            Customer.Customer roland = new Customer.Customer("Roland", 69, "Somewhere in Toronto", new Customer.AccountDetails("3232", new Customer.Card("Chequing", 123, 123, 123, 10), null));
            Console.WriteLine("Customer: {0}\nAddress: {1}\nAge: {2}\nCustomer Number: {3}\nTotal Cash: {4}", roland.Name, roland.Address, roland.Age, roland.Account.CustomerNumber, roland.Account.TotalCash());

            Console.ReadKey(); //waits for keyinput
        }
    }




}
