/*

*/

using System;
using System.Collections.Generic; //needed for lists

namespace listAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a list of Employees
            List<Account> accountList = new List<Account>();
             
            //Add some hourly employees to the list for testing
            accountList.Add(new SavingsAccount (11111, "Savings", 5000,.05));
            accountList.Add(new SavingsAccount (22222, "Savings", 17525,.10));
            accountList.Add(new SavingsAccount (33333, "Savings", 25000,.20));
            //Add some hourly employees to the list for testing
            accountList.Add(new CheckingAccount (12345, "Checking", 7000,.02));
            accountList.Add(new CheckingAccount (67891, "Checking", 500,.03));
            //Add some hourly employees to the list for testing
            accountList.Add(new CDAccount (45454, "CD", 5000,.05,100));
            accountList.Add(new CDAccount (78787, "CD", 22000,.10,500));
/*
            //Print the list
            foreach (Account anAccount in accountList)
            {
                Console.WriteLine(anAccount);
            }

            accountList[1].Deposit(1000);
            accountList[2].Deposit(-5);

            accountList[0].Withdrawal(1000);
                     
            accountList[3].Deposit(-19);
            accountList[4].Withdrawal(100);

*/
            //Declare variables
            bool acctFound;
            bool userChoice;
            string userChoiceString;

            // Repeat main loop
            do
            {
                //Get valid input
                do
                {
                    //initialize variables
                    userChoice = false;

                    //Provide the user a menu of options
                    Console.WriteLine("");
                    Console.WriteLine("Please choose an option below:");
                    Console.WriteLine("L: Get a list of accounts.");
                    Console.WriteLine("D: Make a deposit.");
                    Console.WriteLine("W: Make a withdrawal.");
                    Console.WriteLine("Q: To close the application.");

                    //Get a valid user option
                    string input = Console.ReadLine();
                    userChoiceString = input.ToUpper();

                    userChoice = (userChoiceString == "L" ||
                                  userChoiceString == "D" ||
                                  userChoiceString == "W" ||
                                  userChoiceString == "Q");
                    
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } while (!userChoice);

                //If option is L - will list all accounts
                if (userChoiceString == "L")
                {
                    Console.WriteLine("Option L.");

                    //Print the list
                    foreach (Account anAccount in accountList)
                    {
                        Console.WriteLine(anAccount);
                    }
                }

                //If option is D - will make a deposit to account
                else if (userChoiceString == "D")
                {
                    //Console.WriteLine("Option D.");
                    acctFound = false;
                    Console.WriteLine("Enter the Account for the deposit: ");
                    int findAcct = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Deposit amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    if (amount < 0)
                    {
                        Console.WriteLine("Amount must be > 0. Try again!");
                        Console.WriteLine("Deposit amount");
                        amount = Convert.ToDouble(Console.ReadLine());
                    }

                    foreach (Account anAccount in accountList)
                    {
                        if (anAccount.accountID == findAcct)
                        {
                            anAccount.Deposit(amount);
                            acctFound = true;
                        }
                    }
                    if(!(acctFound))                    
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Account not found.");
                    }
                }

                //If option is W - will make withdrawal from account
                else if (userChoiceString == "W")
                {
                    //Console.WriteLine("Option W.");
                    acctFound = false;                   
                    Console.WriteLine("Enter the Account for the withdrawal: ");
                    int findAcct = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Withdrawal amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    if (amount < 0)
                    {
                        Console.WriteLine("Amount must be > 0. Try again!");
                        Console.WriteLine("Withdrawal amount");
                        amount = Convert.ToDouble(Console.ReadLine());
                    }

                    foreach (Account anAccount in accountList)
                    {
                        if (anAccount.accountID == findAcct)
                        {                        
                            anAccount.Withdrawal(amount);
                            acctFound = true;
                        }
                    }
                    if(!(acctFound))                  
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Account not found.");
                    }

                }

                //If option is Q - Quit
                else
                {
                    Console.WriteLine("Thank you, good bye!");
                }           
               
            } while (!(userChoiceString == "Q"));


        }//end Main
    }//end class
}//end namespace