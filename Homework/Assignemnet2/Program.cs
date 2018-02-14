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

        public double getCheqingBalance()
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

            Account account3 = new Account();
            account3.setAccount(15000, 23000);

            Console.WriteLine("My Savings balance is:"+ account1.getSavingBalance());
            Console.WriteLine("My Cheqing balance is:"+ account1.getCheqingBalance());
            Console.WriteLine("My Saving balance before deduction was:"+ account1.getSavingBalBeforeDeduction());
            Console.WriteLine("My Spouse's Saving balance before deduction was:"+ account2.getSavingBalBeforeDeduction());
            Console.WriteLine("My Current account balance are: SavingSBalance:{0},CheqingBalance:{1} " ,account1.SavingBalance,account1.CheqingBalance);
            Console.WriteLine("My Spouse's current account balance are: SavingBlance:{0}, CheqingBalance:{1}",account2.SavingBalance,account2.CheqingBalance);
            Console.WriteLine("Our Combined account balance are: SavingBalance {0}, CheqingBalance: {1}",account3.SavingBalance,account3.CheqingBalance);

            Console.ReadKey();
        }
    }
}
