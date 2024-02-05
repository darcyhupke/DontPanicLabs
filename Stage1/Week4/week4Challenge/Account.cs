/* 
Program Description: This is an abstract parent class called Account.

Requirements:
Must be an abstract class (objects of this type will not be created).
Will have ID, Type, and Balance.
Need Deposit Method.
Need Withdrawal Abstarct Method.
Interest will be an Interface 

*/


using System;

namespace listAccount
{
    //this is an abstract class so it can't be instantiated (objects of this type can't be created)
    abstract class Account 
    {

        //Properties
        public int accountID
        { get; set; }

        public string accountType
        { get; set; }

        public double accountBalance
        { get; set; }

        public Account() //default contructor
        {
            accountID = 0;
            accountType = "";
            accountBalance = 0.0;
        }

        public Account(int newAcctID, string newAcctType, double newAcctBalance) //constructor
        {
            accountID = newAcctID;
            accountType = newAcctType;
            accountBalance = newAcctBalance;
        }

        //Just an FYI...nothing goes in parent class for Interest because that is an interface.
        

        //GetWithdrawal is an abstract method that will be used in child classes
        public abstract void Withdrawal(double withdrawalAmount);
        
        
        public void Deposit(double depositAmt)
        {
            //if (depositAmt > 0)
                accountBalance = accountBalance + depositAmt;
            //else
            //    Console.WriteLine("Deposit must be a positive value.");
        }

        public override string ToString()
        {
            return "\nAccount Number: " + accountID + "\nAccount Type: " + accountType + "\nBalance: " + accountBalance;
        }
        
    }//end class Employee
}//end namespace listInterface