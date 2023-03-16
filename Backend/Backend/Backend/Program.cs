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
        Console.WriteLine("Customer: {0}\nAddress: {1}\nAge: {2}\nTotal Cash: {3}", roland.Name, roland.Address, roland.Age, roland.TotalCash());

        JAABS.ATMMachine.ATMMachine ATM = new JAABS.ATMMachine.ATMMachine("CIBC", "30321758753", 1000, 1000, 1000, 1000, 1000, new JAABS.Bank.Bank("CIBC", "HI", "HELLO"));
        Console.WriteLine("Bank Owner Name: {0}", ATM.MainBank.Name);
        while(true)
        {
            while(!ATM.LoggedIn)
            {
                ATM.CheckCard();
                if (ATM.CardIn)
                {
                    Console.Write("Enter Pin: ");
                    string pin = Console.ReadLine();
                    ATM.LogIn(pin);
                }
            }
        }


        Console.ReadKey(); //waits for keyinput

    }
}
