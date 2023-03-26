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


        JAABS.ATMMachine.ATMMachine ATM = new JAABS.ATMMachine.ATMMachine("TMBank", "30321758753",new JAABS.Bank.Bank("TMBank", "CustomerData.txt", "HashData.txt"));
        Console.WriteLine("Bank Owner Name: {0}", ATM.MainBank.Name);
        while(true)
        {
            Console.Clear();
            while(!ATM.LoggedIn)
            {
                ATM.CheckCard();
                if (ATM.CardIn)
                {
                    Console.Write("Enter Pin: ");
                    string pin = Console.ReadLine();
                    ATM.LogIn(pin);
                }
                else
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
                        string depositChoice = Console.ReadLine();
                        if (depositChoice == "1")
                        {
                            Console.WriteLine("Enter 'savings' or 'chequing'");
                            choice = Console.ReadLine();
                            ATM.DepositCash(choice);
                        }
                        else if (depositChoice == "2")
                        {
                            Console.Write("Enter 'savings' or 'chequing'");
                            choice = Console.ReadLine();
                            //read from cheque
                            JAABS.Bank.Cheque cheque = ATM.readCheque("cheque.txt");
                            if (choice.Equals("savings") || choice.Equals("chequing")) //error checking
                            {
                                if (ATM.DepositCheques(cheque, choice))
                                {
                                    Console.WriteLine("Successfully deposited cheque!\n");
                                }
                                else
                                {
                                    Console.WriteLine("Failed to deposit cheque!\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Failed to specify savings or chequing!\n");
                            }
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
                    else if (choice == "2")
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
