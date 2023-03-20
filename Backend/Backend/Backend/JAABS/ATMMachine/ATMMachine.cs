using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.ATMMachine
{
    internal class ATMMachine
    {
        public string CardNumber;
        public bool CardIn;
        public bool LoggedIn;
        public string BankOwner;
        public string MachineNumber;
        public int FiveDollars;
        public int TenDollars;
        public int TwentyDollars;
        public int FiftyDollars;
        public int HundredDollars;
        public JAABS.Bank.Bank[] Banks;
        public JAABS.Bank.Bank MainBank;
        public string CardType;
        public ATMMachine(string bankOwner, string machineNumber, int fiveDollars, int tenDollars, int twentyDollars, int fiftyDollars, int hundredDollars, JAABS.Bank.Bank mainbank)
        {
            CardIn = false;
            LoggedIn = false;
            BankOwner = bankOwner;
            MachineNumber= machineNumber;
            FiveDollars= fiveDollars;
            TenDollars= tenDollars;
            TwentyDollars= twentyDollars;
            FiftyDollars = fiftyDollars;
            HundredDollars = hundredDollars;
            MainBank = mainbank;
            
        }

        public void LogIn(string pin)
        {
            string cardNumber = JAABS.ATMMachine.CardReader.Read();
            pin = JAABS.Encryptioner.EncryptKey(pin);
            CardNumber = JAABS.Encryptioner.EncryptKey(cardNumber);
            if (cardNumber.Length != 16)
            {
                CardType = "Credit";
                Console.WriteLine("Card type: Credit");
            }
            else
            {
                CardType = "Debit";
                Console.WriteLine("Card type: Debit");
            }

            LoggedIn = MainBank.VerifyLogin(CardNumber, pin);
            if (LoggedIn)
            {
                Console.WriteLine("Logged In!\n");
            }
            else
            {
                Console.WriteLine("Enter pin again.");
            }
        }

        public void Withdraw(int amount, string type)
        {
            if (amount % 5 != 0)
            {
                Console.WriteLine("Invalid value (Not increment of 5)");
                return;
            }
            bool request = false;
            if (CardType == "Debit")
            {
                request = MainBank.requestWithdraw(CardNumber, amount, type);

            }
            else if (CardType == "Credit")
            {
                request = MainBank.orderCash(CardNumber, amount);
            }
            if (request)
            {
                while (amount > 0)
                {
                    if (amount >= 100)
                    {
                        HundredDollars--;
                        amount -= 100;
                    }
                    else if (amount >= 50)
                    {
                        FiftyDollars--;
                        amount -= 50;
                    }
                    else if (amount >= 20)
                    {
                        TwentyDollars--;
                        amount -= 20;
                    }
                    else if (amount >= 10)
                    {
                        TenDollars--;
                        amount -= 10;
                    }
                    else if (amount >= 5)
                    {
                        FiveDollars--;
                        amount -= 5;
                    }
                }
                Console.WriteLine("Withdraw Complete");
            }
            else if (CardType == "Credit")
            {
                Console.WriteLine("Over the limit");
            }
            else if (CardType == "Debit")
            {
                Console.WriteLine("Insufficient funds");
            }

        }

        public void CheckCard()
        {
            if (JAABS.ATMMachine.CardReader.Read() == "") CardIn = false;
            else CardIn = true;
        }
        public void EjectCard()
        {
            JAABS.ATMMachine.CardReader.Eject();
        }

        public void LogOut()
        {
            LoggedIn = false;
        }

        public bool DepositCash(int toDeposit)
        {

            return false;
        }

        //make a cheque class?
        public bool DepositCheques(JAABS.Bank.Cheque toDeposit, string choice)
        {
            if (CardType.Equals("Debit"))
            {
                MainBank.depositCheque(toDeposit, CardNumber, choice);
                return true;
            }
            return false;
        }

        public bool WithdrawCash(int toWithdraw)
        {

            return false;
        }

        //make transfer struct plz
        public bool Transfer()
        {

            return false;
        }

        public bool payPayees()
        {
            return false;
        }

        public JAABS.Bank.Cheque readCheque(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            return new JAABS.Bank.Cheque(lines[0], lines[1], lines[2], lines[3], lines[4],lines[5], int.Parse(lines[6]));
        }

        //Total cash inside the machine
        public bool addCash()
        {
            return false;
        }

        //add check functions for atm related methods.
    }
}
