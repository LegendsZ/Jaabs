using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Tester
{
    public static bool Test()
    {
        bool smthFailed = false;

        //Unit 1 //checking if atm can read/recognize card
        JAABS.ATMMachine.ATMMachine ATM = new JAABS.ATMMachine.ATMMachine("TMBank", "30321758753", new JAABS.Bank.Bank("TMBank", "CustomerData.txt", "HashData.txt"));
        ATM.CheckCard();
        if (!ATM.CardIn)
        {
            Console.WriteLine("---------------ATM not reading card!\n");
            return false;
        }

        //Unit 2 //testing if pin check is right
        ATM.LogIn("0000");
        if (ATM.LoggedIn)
        {
            Console.WriteLine("---------------ATM login check not working!\n");
            return false;
        }

        //Unit 3 //testing login pin check
        ATM.LogIn("1234");
        //for debit card
        File.WriteAllText("CardReader.txt", "1004864910513864");
        {//Debit testing
            if (ATM.LoggedIn)
            {
                string[] lines = File.ReadAllLines("CustomerData.txt");
                string[] token = lines[0].Split(',');
                {
                    //Unit 4 //testing withdraw  
                    int initial = int.Parse(token[7]);
                    ATM.Withdraw(500, "2");
                    lines = File.ReadAllLines("CustomerData.txt");
                    token = lines[0].Split(',');
                    int final = int.Parse(token[7]);
                    if (initial - final != 500)
                    {
                        Console.WriteLine("---------------ATM withdraw not working!\n");
                        smthFailed = true;
                    }
                }
                {
                    //Unit 5 // testing deposit cash
                    int initial = int.Parse(token[7]);
                    File.WriteAllText("MoneyReader.txt", "5");
                    ATM.DepositCash("chequing");
                    token = lines[0].Split(',');
                    int final = int.Parse(token[7]);
                    if (initial - final != 5)
                    {
                        Console.WriteLine("---------------ATM deposit cash not working!\n");
                        smthFailed = true;
                    }
                }
                {
                    //Unit 6 // testing deposit cheque
                    int initial = int.Parse(token[7]);
                    JAABS.Bank.Cheque cheque = ATM.readCheque("cheque.txt");
                    ATM.DepositCheques(cheque, "chequeing");
                    token = lines[0].Split(',');
                    int final = int.Parse(token[7]);
                    if (initial - final != 50)
                    {
                        Console.WriteLine("---------------ATM deposit cheque not working!\n");
                        smthFailed = true;
                    }
                }
                {
                    //Unit 6 // testing deposit cheque
                    int initial = int.Parse(token[7]);
                    JAABS.Bank.Cheque cheque = ATM.readCheque("cheque.txt");
                    ATM.DepositCheques(cheque, "chequeing");
                    token = lines[0].Split(',');
                    int final = int.Parse(token[7]);
                    if (initial - final != 50)
                    {
                        Console.WriteLine("---------------ATM deposit cheque not working!\n");
                        smthFailed = true;
                    }
                }

                //Unit last
                ATM.LogOut();
                if (ATM.CardIn)
                {
                    Console.WriteLine("---------------ATM card logout not working\n");
                    smthFailed = true;
                    return false;
                }
            }
        }

        //credit card cannot be tested at the moment.
        return smthFailed;
        File.WriteAllText("CardReader.txt", "CREDIT CARD NUMBER");
        {//credit testing

        }
        return true;
    }
}
