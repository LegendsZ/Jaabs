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


        JAABS.ATMMachine.ATMMachine ATM = new JAABS.ATMMachine.ATMMachine("CIBC", "30321758753", 1000, 1000, 1000, 1000, 1000, new JAABS.Bank.Bank("TMBank", "CustomerData.txt", "custHashes"));
        Console.WriteLine("Bank Owner Name: {0}", ATM.MainBank.Name);
        while(true)
        {
            while(!ATM.LoggedIn)
            {
                ATM.CheckCard();
                if (ATM.CardIn)
                {
                    Console.Write("Enter Pin (no verification yet so put in 1234 for valid login, anything else for invalid): ");
                    string pin = Console.ReadLine();
                    ATM.LogIn(pin);
                }
                if (!ATM.CardIn)
                {
                    System.Threading.Thread.Sleep(50);
                    Console.WriteLine("Waiting for card");
                }
            }
            while (ATM.LoggedIn)
            {
                ATM.CheckCard();
                if (!ATM.CardIn)
                {
                    ATM.LogOut();
                    break;
                }
                System.Threading.Thread.Sleep(50);
                if (ATM.CardType == "Debit")
                { 
                    Console.Write("Enter 1 to deposit, 2 to withdraw, 3 transfer: ", ATM.CardNumber);
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.Write("Enter 1 to deposit cash, enter 2 to deposit cheque: ");
                        string withdrawChoice = Console.ReadLine();
                        if (withdrawChoice == "1")
                        {

                        }
                        else if (withdrawChoice == "2")
                        {

                        }
                    }
                    if (choice == "2")
                    {
                        Console.Write("Enter 1 for chequing, 2 for savings: ");
                        string accountChoice = Console.ReadLine();
                        Console.Write("Enter how much: ");
                        string amount = Console.ReadLine();

                        ATM.Withdraw(Convert.ToInt32(amount), accountChoice);
                    }
                }
                if (ATM.CardType == "Credit")
                {
                    Console.Write("Enter 1 to pay, 2 to withdraw money");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Meow");
                    }
                    if (choice == "2")
                    {
                        Console.Write("Enter how much: ");
                        string amount = Console.ReadLine();
                        ATM.Withdraw(Convert.ToInt32(amount), null);
                    }
                }

            }
        }


        Console.ReadKey(); //waits for keyinput

    }
}
