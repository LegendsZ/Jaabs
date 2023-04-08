using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Recipt class
namespace JAABS.Customer
{
    public class Receipt
    {

        //Recipt variables
        string BankOwner;
        string TransactionType;
        string AccountType;
        string Balance;
        string CardNumber;
        string MachineID;
        string ReferenceNumber;
        string Cost;
        string ActiveBank;
        string CardType;

        //Intialize recipt object
        public Receipt(string bankOwner, string transactionType, string accountType, string balance, string cardNumber, string machineID, string referenceNumber, string cost, string activeBank, string cardType)
        {
            BankOwner = bankOwner;
            TransactionType = transactionType;
            AccountType = accountType;
            Balance = balance;
            CardNumber = cardNumber;
            MachineID = machineID;
            ReferenceNumber = referenceNumber;
            Cost = cost;
            ActiveBank = activeBank;
            CardType = cardType;

        }

        //Print recipt
        public void Print()
        {
            string censored = "";
            CardNumber = JAABS.Encryptioner.DecryptKey(CardNumber);
            //Censor card number
            for (int i = 0; i < CardNumber.Length; i++)
            {
                if (i < CardNumber.Length - 4)
                {
                    censored += "*";
                }
                else
                {
                    censored += CardNumber[i];
                }
            }

            //Print all Services provided during session
            System.IO.File.WriteAllText("PrintedReceipt.txt", "");
            string receipt =
                "\tATM SERVICES PROVIDED BY " + BankOwner.ToUpper() + "\t" +
                "\n" +
                "\n" +
                "MACHINE ID".PadRight(20) + MachineID.PadLeft(20) + "\n" +
                "CARD NUMBER".PadRight(20) + censored.PadLeft(20) + "\n" +
                "\n" +
                "REFERENCE ID".PadRight(20) + ReferenceNumber.PadLeft(20) + "\n" +
                CardType.ToUpper().PadRight(20) + AccountType.PadLeft(20) + "\n" +
                TransactionType.PadRight(20) + Cost.PadLeft(20) + "\n" +
                "BALANCE".PadRight(20) + Balance.PadLeft(20) + "\n" +
                "\n\n" +
                "\tThank you for banking with " + ActiveBank.ToUpper() + "\t" + "\n";
            System.IO.File.WriteAllText("PrintedReceipt.txt", receipt);
        }
    }

}
