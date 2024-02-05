/*
4 properties - Acct ID, Acct Type, and Acct Balance (from parent). Annual interest will be the 4th property
need to calculate annual interest (acct balance * interest rate)
need to calculate withdrawal amount 
    if amount of withdrawal < balance 
        then balance - withdrawal = balance
*/

using System;

namespace listAccount
{
    class SavingsAccount : Account, IInterest
    {
        public double annualInterest //property
        { get; set; }

        
        public SavingsAccount() : base() //default constructor
        {
            annualInterest = 0.0;
        }

        public SavingsAccount(int newAcctID, string newAcctType, double newAcctBalance, double newAnnualInterest) : base(newAcctID, newAcctType, newAcctBalance) //another constructor
        {
            annualInterest = newAnnualInterest;
        }

        public double GetInterest() //Interface method
        {
            return accountBalance * annualInterest;    
        }

        //implement abstract method GetWithdrawal
        public override void Withdrawal(double withdrawalAmount)
        {
            if (accountBalance >= withdrawalAmount)
                accountBalance = accountBalance - withdrawalAmount;
            else
                Console.WriteLine("");
                Console.WriteLine("Check your balance. Withdrawal not accepted.");
        }



        public override string ToString()
        {
            return base.ToString() + "\nAnnual Interest Earned: " + GetInterest() + "\nAnnual Interest Rate: " + annualInterest;
        }


    }//end class
}//end namespace  Account