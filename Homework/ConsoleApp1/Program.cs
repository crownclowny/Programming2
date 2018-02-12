using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDemo
{
    class Account
    {
        //instance variables
        private string AccountAdd;
        private string AccountType;

        //constructor

        public Account()
        {
        }
        public Account(string AccountAdd)
        {
            this.AccountAdd = AccountAdd;
        }
        public Account(string AccountAdd, string AccountType)
        {
            this.AccountAdd = AccountAdd;
            this.AccountType = AccountType;

        }
        //property
        public String Name
        { get; set; }

        public double Bal
        { get; set; }


        //methods
        public string getAccountAdd()
        {
            return AccountAdd;
        }
        public void setAccountAdd(string AccountAdd)
        {
            this.AccountAdd = AccountAdd;

        }

        public string getAccountType()
        {
            return AccountType;
        }
        public void setAccountType(string AccountType)
        {
            this.AccountType = AccountType;

        }


    }
}



namespace MyFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Account();
            Account A2 = new Account("231 DL");
            Account A3 = new MyFirstDemo.Account("123 DL", "Savings");

            Console.WriteLine("A1's account address = " + A1.getAccountAdd());
            A1.setAccountAdd("Eramosa Crt");
            Console.WriteLine("\nThe address now is " + A1.getAccountAdd());
            A1.Name = "Syed";
            Console.WriteLine("\nThe Name property contains " + A1.Name);


            double accBal;
            Console.WriteLine("\nPlease enter the balance: ");
            accBal = Convert.ToDouble(Console.ReadLine());
            A1.Bal = accBal;
            Console.WriteLine("A1's account balance = " + A1.Bal);
            Console.ReadKey();

        }
    }
}

