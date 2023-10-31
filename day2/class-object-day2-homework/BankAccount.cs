using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object_day2_homework
{
    //--- Exercise 5 ---
    //Class: BankAccount
    //- Consider which fields/variables a bank account might need.
    //- Consider what behaviour it needs to implement.
    //- Now write the class! Both Constructor and a few required methods.
    //Create an object to test the behaviour of your new class!
    internal class BankAccount
    {
        //public string customerName;
        //public string accountNumber;
        //public string bankName;
        //public int amount;

        //public double getamount() { }
        //public double addamount(double amount) { }
        //public double withdrawamount(double amount) { }

       
            string accountOwner;
            string accountNumber;
            double accountBalance;

            public BankAccount(string accountOwner, string accounterNumber, double accountStartAmount)
            {
                this.accountNumber = accounterNumber;
                this.accountOwner = accountOwner;
                this.accountBalance = accountStartAmount;
            }
            public double GetBalance()
            {
                return accountBalance;
            }
            public string GetAccountInfo()
            {
                return $"The balance of account {accountNumber} owned by {accountOwner} is currently: {accountBalance}";
            }
            public double Deposit(double amount)
            {
                accountBalance += amount;
            Console.WriteLine($"  the new amount is {accountBalance}");
            return accountBalance;
            }
            public void Withdraw(double amount)
            {
                accountBalance -= amount;
            }
        
    }
}
