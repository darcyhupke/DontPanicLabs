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
    class CDAccount : Account, IInterest
    {
        public double annualInterest //property
        { get; set; }

        public double withdrawalPenalty //property
        { get; set; }

        
        public CDAccount() : base() //default constructor
        {
            annualInterest = 0.0;
            withdrawalPenalty = 0.0;
        }

        public CDAccount(int newAcctID, string newAcctType, double newAcctBalance, double newAnnualInterest, double newWithdrawalPenalty) : base(newAcctID, newAcctType, newAcctBalance) //another constructor
        {
            annualInterest = newAnnualInterest;
            withdrawalPenalty = newWithdrawalPenalty;
        }

        public double GetInterest() //Interface method
        {
            return accountBalance * annualInterest;    
        }

        //implement abstract method GetWithdrawal
        public override void Withdrawal(double withdrawalAmount)
        {     
            double penaltywithdrawAmount = withdrawalAmount + withdrawalPenalty;
            
            if (penaltywithdrawAmount <= accountBalance)   
            {         
                accountBalance = accountBalance - penaltywithdrawAmount;
                Console.WriteLine("\nWithdrawal accepted!");
            }
            else            
                Console.WriteLine("\nCheck your balance. Remember you have an early withdrawal penalty!");          
        }



        public override string ToString()
        {
            return base.ToString() + "\nAnnual Interest Earned: " + GetInterest() + "\nAnnual Interest Rate: " + annualInterest + "\nEarly Withdrawal Penalty Amount: " + withdrawalPenalty;
        }


    }//end class
}//end namespace  Account