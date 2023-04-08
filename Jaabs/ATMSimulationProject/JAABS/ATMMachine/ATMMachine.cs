using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.ATMMachine
{
    public class ATMMachine
    {
        //Variables
        static ATMMachine ATM;
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
        public JAABS.Bank.Bank ActiveBank;
        public string CardType;
        public double REFERENCE;

        //Intilaize ATM objects
        public ATMMachine(string bankOwner, string machineNumber, JAABS.Bank.Bank mainbank)
        {
            //Starting values
            CardIn = false;
            LoggedIn = false;
            BankOwner = bankOwner;
            MachineNumber= machineNumber;
            ActiveBank = mainbank;
            InitializeSubBanks(mainbank);
            ReadMoney("Vault.txt");
            ATM = this;
            REFERENCE = 10000000;
        }

        //Initalize sub banks
        public void InitializeSubBanks(JAABS.Bank.Bank mainbank)
        {
            //Set sub bank values
            Banks = new JAABS.Bank.Bank[3];
            Banks[0] = mainbank;
            Banks[1] = new JAABS.Bank.Bank("Bank 2", "Bank2CustomerData.txt", "Bank2HashData.txt");
            Banks[2] = new JAABS.Bank.Bank("Bank 3", "Bank3CustomerData.txt", "Bank3HashData.txt");
        }

        //Read money method
        public void ReadMoney(string filename)
        {
            //Read money values from text file
            string[] values = File.ReadAllLines(filename);
            FiveDollars = Convert.ToInt32(values[0]);
            TenDollars = Convert.ToInt32(values[1]);
            TwentyDollars = Convert.ToInt32(values[2]);
            FiftyDollars = Convert.ToInt32(values[3]);
            HundredDollars = Convert.ToInt32(values[4]);
        }

        //Deposit Cash Method
        public void DepositCash(string type)
        {
            string key = "1";
            int money;
            int total = 0;

            //While access granted
            while (key == "1")
            {
                money = JAABS.ATMMachine.MoneyReader.Read();

                //Increment the respective cash amount
                switch(money)
                {
                    case 5:
                        FiveDollars++;
                        break;
                    case 10:
                        TenDollars++;
                        break;
                    case 20:
                        TwentyDollars++;
                        break;
                    case 50:
                        FiftyDollars++;
                        break;
                    case 100:
                        HundredDollars++;
                        break;
                    default:
                        Console.WriteLine("Invalid amount of money");
                        break;

                }
                //Update total Amount
                total += money;
                Console.WriteLine("Enter 1 to deposit more, 2 if done depositing");
                key = Console.ReadLine();
            }
            int cost = total;

            //Deposit request is invalid
            if (ActiveBank.requestDeposit(CardNumber, total, type) == false)
            {
                Console.WriteLine("Suspicious amount deposited");
                //Should pop an Account Blocked message + Call 470-0123-123 To Resolve Issues
            }
            //Proceed with deposit
            else
            {
                Console.WriteLine("Deposit successful");
                JAABS.Customer.Receipt receipt = new JAABS.Customer.Receipt(BankOwner, "DEPOSIT", type, ActiveBank.RequestBalance(CardNumber, type), CardNumber, MachineNumber, string.Format("{0}", REFERENCE++), string.Format("{0:0.00}", cost), ActiveBank.Name, CardType);
                receipt.Print();
                LogOut();
                EjectCard();
            }


        }

        //check balance method
        public String CheckBalance(string choice)
        {
            //return the balance
            return ActiveBank.RequestBalance(CardNumber, choice);
        }

        //Login method
        public void LogIn(string pin)
        {
            //Get card number
            string cardNumber = JAABS.ATMMachine.CardReader.Read();
            Console.WriteLine("Card: {0}", cardNumber);
            pin = JAABS.Encryptioner.EncryptKey(pin);
            CardNumber = JAABS.Encryptioner.EncryptKey(cardNumber);

            //Determine card type
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

            //Decrypt card
            switch (JAABS.Encryptioner.DecryptKey(Char.ToString(CardNumber[0])))
            {
                case "1":
                    ActiveBank = Banks[0];
                    break;
                case "2":
                    ActiveBank = Banks[1];
                    break;
                case "3":
                    ActiveBank = Banks[2];
                    break;
            }
            //Confirm the card is valid
            int status = ActiveBank.VerifyLogin(CardNumber, pin);

            //Confirm login
            if (status == 0)
            {
                LoggedIn = true;
                Console.WriteLine("Logged In!\n");
            }
            //Card blocked
            else if (status == 2)
            {
                Console.WriteLine("Account is temporarily blocked. Call 1-777-4421 or go to the nearest bank to resolve the issue");
                return;
            }
            //Pin wrong
            else
            {
                Console.WriteLine("Invalid pin. Try again");
            }

        }

        //Print recipt
        public void PrintReceipt()
        {

        }

        //Withdraw method
        public void Withdraw(int amount, string type)
        {
            //Check amount
            if (amount % 5 != 0)
            {
                Console.WriteLine("Invalid value (Not increment of 5)");
                return;
            }
            bool request = false;
            //Debit card for withdraw
            if (CardType == "Debit")
            {
                request = ActiveBank.requestWithdraw(CardNumber, amount, type);

            }
            //Credit card for withdraw
            else if (CardType == "Credit")
            {
                request = ActiveBank.orderCash(CardNumber, amount);
            }
            int cost = amount;
            //Update the amount
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
                JAABS.Customer.Receipt receipt = new JAABS.Customer.Receipt(BankOwner, "WITHDRAW", type, ActiveBank.RequestBalance(CardNumber, type), CardNumber, MachineNumber, string.Format("{0}", REFERENCE++), string.Format("{0:0.00}", cost), ActiveBank.Name, CardType);
                receipt.Print();
                UpdateVault();
                LogOut();
                EjectCard();
            }
            //Display invlaid messsges
            else if (CardType == "Credit")
            {
                Console.WriteLine("Over the limit");
            }
            else if (CardType == "Debit")
            {
                Console.WriteLine("Insufficient funds");
            }

        }

        //Check the card for it it is read
        public void CheckCard()
        {
            if (JAABS.ATMMachine.CardReader.Read() == "") CardIn = false;
            else CardIn = true;
        }

        //Eject card
        public void EjectCard()
        {
            JAABS.ATMMachine.CardReader.Eject();
        }

        //Logout of ATM
        public void LogOut()
        {
            CardIn = false;
            CardNumber = "";
            CardType = "";
            LoggedIn = false;
        }


        //Deposit cheques
        public bool DepositCheques(JAABS.Bank.Cheque toDeposit, string choice)
        {
            //Debit deposit
            if (CardType.Equals("Debit"))
            {
                ActiveBank.depositCheque(toDeposit, CardNumber, choice);
                return true;
            }
            return false;
        }

        //Withdraw cash
        public bool WithdrawCash(int toWithdraw)
        {

            return false;
        }

        //make transfer struct
        public bool Transfer()
        {

            return false;
        }

        //Pay payee accounts
        public bool payPayees()
        {
            return false;
        }

        //Read cheque
        public JAABS.Bank.Cheque readCheque(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            return new JAABS.Bank.Cheque(lines[0], lines[1], lines[2], lines[3], lines[4],lines[5], int.Parse(lines[6]));
        }

        //Update bank vault based on performed actions
        public void UpdateVault()
        {

            string VaultMoney = String.Format("{0}\n{1}\n{2}\n{3}\n{4}", FiveDollars, TenDollars, TwentyDollars, FiftyDollars, HundredDollars);
            File.WriteAllText("Vault.txt", VaultMoney);

        }

        //add check functions for atm related methods.
    }
}
