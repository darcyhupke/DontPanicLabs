/*
4 memberships:
    * Regular
    * Executive
    * Non-Profit
    * Corporate
Classes:
    * Abstract class Membership (parent) 
        - Membership ID
        - Type of membership
        - Email 
        - Annual cost
        - Amount of purchases
        - 
    * class RegularMembership (inheritied/child)
        - flat percent for cash-back rewards on all purchases 
    * class ExecMembership (inherited/child)
        - 2 tiers for cach-back - one < 1000 and one > 1000
    * class NonProfitMembership (inherited/child)
        - flat percent for cash-back rewards
        - need a field to indicate if it's military or educational
            - if yes, the reward is doubled
    * class CorpMembership (inherited/child)
        - flat percent for cash-back reward
Methods:
    * Purchase (used by all so only needs to be in parent class)
        - need account ID and amount of purchase (must be > 0)
            - all 4, if ID exists, add purchase to current purchase balance
    * Return (used by all so only needs to be in parent class)
        - need account ID and amount of return (must be > 0)
            - all 4, if ID exists, subtract amount from current purchase balance
    * CashBack 
        - abstract method
        - need account ID (if valid ID)
            - get reward amount
            - print to console "Cash-back reward request for membership xxxxx in
                                the amount of $xxxx has been made"
            - zero out balance
    * SpecialOffer - This will be an interface
        - Regular membership will return 25% of annual membership fee
        - Executive membership will return 50% of annual membership fee
    
*/
using System;
using System.Collections.Generic;

namespace listMemberships
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of Membership accounts
            List<Membership> membershipList = new List<Membership>();
             
            //Add some Regular members to the list for testing
            membershipList.Add(new RegularMembership (11111, "Regular", "dhupke@gmail.com",250,1500));
            membershipList.Add(new RegularMembership (22222, "Regular", "johnsmith@junkmail.com",100,2000));

            //membershipList[0].CashBack(.04);
            //membershipList[0].Purchase(1000);
            //membershipList[1].CashBack(.11);
            //membershipList[1].Purchase(1000);

            //Add some Executive members
            membershipList.Add(new ExecMembership (31313, "Executive", "georgejones@gmail.com",250,500));
            membershipList.Add(new ExecMembership (11223, "Executive", "slimjim@junkmail.com",100,15000));

            //membershipList[2].CashBack(.04);
            //membershipList[2].Purchase(1000);
            //membershipList[3].CashBack(.11);
            //membershipList[3].Purchase(1000);

            membershipList.Add(new NonProfitMembership (77887, "NonProfit", "fredsavage@gmail.com",250,500,"O"));
            membershipList.Add(new NonProfitMembership (44455, "NonProfit", "crazymonkey@junkmail.com",100,15000,"M"));

            //membershipList[4].CashBack(.04);
            //membershipList[4].Purchase(1000);
            //membershipList[5].CashBack(.11);
            //membershipList[5].Purchase(1000);

            membershipList.Add(new CorpMembership (91919, "Corporate", "jimBeam@gmail.com",250,500));
            membershipList.Add(new CorpMembership (66226, "Corporate", "stinkysock@junkmail.com",100,15000));

            //membershipList[6].CashBack(.04);
            //membershipList[6].Purchase(1000);
            //membershipList[7].CashBack(.11);
            //membershipList[7].Purchase(1000);

            //foreach(Membership aMembership in membershipList)
            //{
            //    Console.WriteLine(aMembership);
            //}


            //Declare variables
            bool memberFound;
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

                    //Provide the user a menu of transaction options
                    Console.WriteLine("");
                    Console.WriteLine("Please choose an option below:");
                    Console.WriteLine("L: Get a list of memberships.");
                    Console.WriteLine("P: Enter purchase transaction.");
                    Console.WriteLine("T: Enter a return transaction.");
                    Console.WriteLine("A: Apply cash-back rewards.");
                    Console.WriteLine("C: Enter a new membership.");
                    Console.WriteLine("R: Read the list of memberships.");
                    Console.WriteLine("U: Update a membership.");
                    Console.WriteLine("D: Delete a membership.");
                    Console.WriteLine("Q: To close the application.");

                    //Get a valid user option
                    string input = Console.ReadLine();
                    userChoiceString = input.ToUpper();

                    userChoice = (userChoiceString == "L" ||
                                  userChoiceString == "P" ||
                                  userChoiceString == "T" ||
                                  userChoiceString == "A" ||
                                  userChoiceString == "C" ||
                                  userChoiceString == "R" ||
                                  userChoiceString == "U" ||
                                  userChoiceString == "D" ||
                                  userChoiceString == "Q");
                    
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } while (!userChoice);

                //If option is L - will list all memberships
                if (userChoiceString == "L" || userChoiceString == "R")
                {
                    Console.WriteLine("\nList of Memberships:"); 
                                      
                    //Print the list
                    foreach (Membership aMembership in membershipList)
                    {
                        Console.WriteLine(aMembership);
                    }
                }

                //If option is P - is for entering a purchase transation
                else if (userChoiceString == "P")
                {
                    memberFound = false;
                    Console.WriteLine("\nPurchase Transaction:"); 
                    Console.WriteLine("Enter Membership ID: ");
                    int findMember = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Purchase Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    if (amount < 0)
                    {
                        Console.WriteLine("Amount must be > 0. Try again!");
                        Console.WriteLine("Enter Purchase Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                    }

                    foreach (Membership aMembership in membershipList)
                    {
                        if (aMembership.memberID == findMember)
                        {
                            aMembership.Purchase(amount);
                            Console.WriteLine("\nTransaction accepted.");
                            memberFound = true;
                        }
                    }

                    if (!(memberFound))
                        Console.WriteLine("\nMembership ID not found.");
                }

                //If option is T - is for entering a return transaction
                else if (userChoiceString == "T")
                {
                    memberFound = false;
                    double amount;
                    Console.WriteLine("Return Transaction:"); 
                    Console.WriteLine("Enter Membership ID: ");
                    int findMember = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Enter Return Amount: ");
                    //double amount = Convert.ToDouble(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("Enter Return Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (amount < 0)
                        {
                            Console.WriteLine("Amount must be > 0. Try again!");
                           
                        }
                    } while (amount < 0);
                    
                    foreach (Membership aMembership in membershipList)
                    {
                        if (aMembership.memberID == findMember)
                        {
                            aMembership.PurchaseReturn(amount);
                            Console.WriteLine("Transaction accepted.");
                            memberFound = true;
                        }
                    }

                    if (!(memberFound))
                        Console.WriteLine("\nMembership ID not found.");
                               
                }

                //If option is A - will apply cash-back reward and clear out balance
                else if (userChoiceString == "A")
                {
                    memberFound = false;
                    Console.WriteLine("Apply Cash-Back Reward:");                   
                    Console.WriteLine("Enter Membership ID: ");
                    int findMember = Convert.ToInt32(Console.ReadLine());
                    
                    foreach (Membership aMembership in membershipList)
                    {
                        if (aMembership.memberID == findMember)
                        {
                            aMembership.CashBack(.05);
                            //Console.WriteLine("Transaction accepted.");
                            memberFound = true;
                        }
                    }

                    if (!(memberFound))
                        Console.WriteLine("\nMembership ID not found.");
                }

                //If option is C - will create/add a new membership
                else if (userChoiceString == "C")
                {   
                    bool validEntry;
                    int addMemberID;
                    do
                    {   
                        validEntry = false;                        
                        Console.WriteLine("\nAdd a new membership.");                   
                        Console.WriteLine("Enter Membership ID: ");
                        addMemberID = Convert.ToInt32(Console.ReadLine());
                    
                        foreach (Membership aMembership in membershipList)
                        {
                            if (aMembership.memberID == addMemberID) 
                            {
                                Console.WriteLine("Membership ID already exists. Try again!");                                                          
                                validEntry = false;
                                break;
                            }
                            else
                                validEntry = true;
                        }
                    }while (!(validEntry));                                        

                        Console.WriteLine("\nMembership Type Options: ");
                        Console.WriteLine("R = Regular | E = Executive | N = NonProfit | C = Corporate");
                        string input = Console.ReadLine();
                        string addType = input.ToUpper();
                        string addMemberType;
                        Console.WriteLine("Member Email Contact: ");
                        string addEmail = Console.ReadLine();
                        Console.WriteLine("Annual Cost: ");
                        double addCost = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Purchase Amount: ");
                        double addPurchase = Convert.ToDouble(Console.ReadLine());

                        switch (addType)
                        {
                            case "R":
                                addMemberType = "Regular";
                                membershipList.Add(new RegularMembership(addMemberID, addMemberType, addEmail, addCost, addPurchase));
                                Console.WriteLine("\nRegular Membership " + addMemberID + " has been added.");
                            break;
                            case "E":
                                addMemberType = "Executive";
                                membershipList.Add(new ExecMembership(addMemberID, addMemberType, addEmail, addCost, addPurchase));
                                Console.WriteLine("\nExecutive Membership " + addMemberID + " has been added.");
                            break;
                            case "N":
                                addMemberType = "NonProfit";
                                Console.WriteLine("What type of Non-Profit?");
                                Console.WriteLine("Enter: M = Military | E = Educational | O = Other");
                                string addNonProfitType = Console.ReadLine();
                                membershipList.Add(new NonProfitMembership(addMemberID, addMemberType, addEmail, addCost, addPurchase, addNonProfitType));
                                Console.WriteLine("\nNonProfit Membership " + addMemberID + " has been added.");
                            break;
                            case "C":
                                addMemberType = "Regular";
                                membershipList.Add(new CorpMembership(addMemberID, addMemberType, addEmail, addCost, addPurchase));
                                Console.WriteLine("\nCorporate Membership " + addMemberID + " has been added.");
                            break;
                            default:
                                Console.WriteLine("Invalid Membership Type. Nothing was added, try again!");
                            break;                                                        
                        }       
                }

                //If option is U - will update an existing membership
                else if (userChoiceString == "U")
                {
                    memberFound = false;
                    Console.WriteLine("Update Membership:");                   
                    Console.WriteLine("Enter Membership ID: ");
                    int findMember = Convert.ToInt32(Console.ReadLine());
                    
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                        if ((membershipList[index].memberID) == findMember)
                        {
                            Console.WriteLine("Update email: ");
                            string updEmail = Console.ReadLine();
                            membershipList[index].memberEmail = updEmail;
                            Console.WriteLine("Update Annual Fee: ");
                            double updFee = Convert.ToDouble(Console.ReadLine());
                            membershipList[index].memberAnnualFee = updFee;
                            Console.WriteLine("Update purchase amount: ");
                            double updPurchase = Convert.ToDouble(Console.ReadLine());
                            membershipList[index].memberPurchaseBalance = updPurchase;
                            
                            memberFound = true;
                            Console.WriteLine("\nMembership ID " + findMember + " has been updated.");
                        }
                    }

                    if (!(memberFound))
                        Console.WriteLine("\nMembership ID not found.");
                }

                //If option is D - will apply cash-back reward and clear out balance
                else if (userChoiceString == "D")
                {
                    memberFound = false;
                    Console.WriteLine("Delete a Membership:");                   
                    Console.WriteLine("Enter Membership ID: ");
                    int findMember = Convert.ToInt32(Console.ReadLine());
                    
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                        if ((membershipList[index].memberID) == findMember)
                        {
                            membershipList.RemoveAt(index);
                            memberFound = true;
                        }
                    }
                    if (memberFound)
                        Console.WriteLine("\nMembership ID " + findMember + " has been deleted.");
                    else
                        Console.WriteLine("Employee not found. Please try again!");
                }

                //If option is Q - will close the application
                else 
                {
                    Console.WriteLine("Thank you, good bye!");     
                }
            } while (!(userChoiceString == "Q"));
        }//end main
    }//end Program
}//end namespace