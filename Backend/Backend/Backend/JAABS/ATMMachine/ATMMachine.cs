using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.ATMMachine
{
    internal class ATMMachine
    {
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
            LoggedIn = MainBank.VerifyLogin(cardNumber, pin);
            Console.WriteLine("Logged In!\n");
            Console.WriteLine("Card Number: {0}\n", cardNumber);
        }

        public void CheckCard()
        {
            CardIn = true;
        }
        public void EjectCard()
        {
            JAABS.ATMMachine.CardReader.Eject();
        }

        public bool DepositCash(int toDeposit)
        {

            return false;
        }

        //make a cheque class?
        public bool DepositCheques(int toDeposit)
        {

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

        public int checkBalance()
        {
            return 0;
        }

        //make transaction class plz, change ret type of the func to Transaction list
        public int checkTransactions()
        {
            return -1;
        }
        //Total cash inside the machine
        public bool addCash()
        {
            return false;
        }

        //add check functions for atm related methods.
    }
}
