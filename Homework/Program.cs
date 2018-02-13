using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnet2
{
    class Account
    {
        // Instanca Variable
        private double SavingBalance;
        private double CheqingBalance;

        
        //method 
        public void setAccount(double sb, double cb)
        {
            SavingBalance = sb;
            CheqingBalance = cb;
            
        }

        public double getSavingBalance()
        {
            return SavingBalance;
        }

        public double getChequingBalance()
        {
            return CheqingBalance;
        }

        public double getSavingBalBeforeDeduction()
        {
            double Deduction = SavingBalance + 10.0;
            return Deduction;
        }

        //Overriding Tostring()
        public override string ToString()
        {
            return string.Format("Svaings Balance: {0},Cheqing's Balance:{1}", SavingBalance, CheqingBalance);
        }

        //Operator overloading for + 
        public static Account operator +( Account a, Account b)
        {
            Account account = new Account();
            account.SavingBalance = a.SavingBalance + b.SavingBalance;
            account.CheqingBalance = a.CheqingBalance + b.CheqingBalance;
            return account;
        }

        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.setAccount(5000,8000);

            Account account2 = new Account();
            account2.setAccount(10000,15000);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
