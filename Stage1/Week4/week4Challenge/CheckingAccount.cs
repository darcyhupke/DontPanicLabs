/*
4 properties - Acct ID, Acct Type, and Acct Balance (from parent). 
               Annual fee will be the 4th property and will be a flat $50 charge
need to calculate annual interest (acct balance * interest rate)
need to calculate withdrawal amount 
    if amount of withdrawal < balance 
        then balance - withdrawal = balance
*/

using System;

namespace listAccount
{
    class CheckingAccount : Account, IInterest
    {
        public double annualFee //property
        { get; set; }

        
        public CheckingAccount() : base() //default constructor
        {
            annualFee = 0.0;
        }

        public CheckingAccount(int newAcctID, string newAcctType, double newAcctBalance, double newAnnualFee) : base(newAcctID, newAcctType, newAcctBalance) //another constructor
        {
            annualFee = newAnnualFee;
        }

        public double GetInterest() //Interface method
        {
            return accountBalance * annualFee;    
        }

        //implement abstract method GetWithdrawal
        public override void Withdrawal(double withdrawalAmount)
        {   
            double halfBalance = accountBalance / 2;
            
            if (withdrawalAmount <= halfBalance)   
            {         
                accountBalance = accountBalance - withdrawalAmount;
                Console.WriteLine("\nWithdrawal accepted!");
            }
            else
            {    
                Console.WriteLine("");
                Console.WriteLine("Check your balance. You can only withdrawal 50%.");
            }
        }


        public override string ToString()
        {
            return base.ToString() + "\nAnnual Fee Charge: " + GetInterest() + "\nAnnual Fee Rate: " + annualFee;
        }


    }//end class
}//end namespace  Account