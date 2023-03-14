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


            Customer roland = new Customer("Roland", 69, "Somewhere in Toronto", new Accountdetails("3232", new Card("Chequing", 123, 123, 123, 10), null));
            Console.WriteLine("Customer: {0}\nAddress: {1}\nAge: {2}\nCustomer Number: {3}\nTotal Cash: {4}", roland.Name, roland.Address, roland.Age, roland.Account.CustomerNumber, roland.Account.TotalCash());

            Console.ReadKey(); //waits for keyinput
        }
    }
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } 
        public Accountdetails Account { get; set; }
        
        public Customer(string name, int age, string address, Accountdetails account)
        {
            Name = name;
            Age = age;
            Address = address;
            Account = account;
        }
    }
    internal class Accountdetails
    {
        public string CustomerNumber { get; set; }
        public Card Chequing { get; set; }
        public Card Savings { get; set; }
        public Accountdetails(string customerNumber, Card chequing, Card savings)
        {
            CustomerNumber = customerNumber;
            Chequing = chequing;
            Savings = savings;
        }
        public bool Match(string number)
        {
            return CustomerNumber.Equals(number);
        }
        public double TotalCash()
        {
            double totalCash = 0;
            if (Chequing != null) totalCash += Chequing.Cash;
            if (Savings != null) totalCash += Savings.Cash;
            return totalCash;
        }

    }
    internal class Card
    {
        public string Type { get; set; }
        public int TransitNumber { get; set; }
        public int InstitutionNumber { get; set; }
        public int AccountNumber { get; set; }
        public double Cash { get; set; }
        public Card(string type, int transitnumber, int institutionnumber, int accountnumber, double cash)
        {
            Type = type;
            TransitNumber = transitnumber;
            InstitutionNumber = institutionnumber;
            AccountNumber = accountnumber;
            Cash = cash;
        }

    }




}
