using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace listWhiskeys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of Employees
            List<Whiskey> whiskeyList = new List<Whiskey>();

            //Add some employees to the list to test
            whiskeyList.Add(new Whiskey("Elijah Craig", "Kentucky Bourbon", 4));
            whiskeyList.Add(new Whiskey("Ardbag", "Scotch", 3));

            // Now, loop through each array element and instantiate a whiskey object for each.
            // Note that the constructor with no parameters will be used.
            foreach (Whiskey aWhiskey in whiskeyList)
            {
                Console.WriteLine(aWhiskey);
            }

            //Reading (finding) an employee in the list
            Console.WriteLine("");
            Console.WriteLine("Lets find a whiskey in the list.");
            Console.WriteLine("Enter whiskey brand name: ");
            string findWhiskey = Console.ReadLine();
            bool whiskeyFound = false;

            foreach (Whiskey aWhiskey in whiskeyList)
            {
                if (aWhiskey.WBrandName == findWhiskey)
                {
                    Console.WriteLine(aWhiskey);
                    whiskeyFound = true;
                }
            }
            if (!(whiskeyFound))
            {
                Console.WriteLine("Whiskey not found.");
            }

            //***********************************************************************
            //Creating (adding) a whiskey to the list
            //***********************************************************************
            Console.WriteLine("");
            Console.WriteLine("Add a new whiskey.");
            Console.WriteLine("Enter Whiskey Brand: ");
            string addWhiskeyBrand = Console.ReadLine();
            Console.WriteLine("Enter Category: ");
            string addCategory = Console.ReadLine();
            Console.WriteLine("Enter Rating (1 - 5): ");
            int addRate = Convert.ToInt32(Console.ReadLine());

            whiskeyList.Add(new Whiskey(addWhiskeyBrand, addCategory, addRate));

            //print list after adding employee.
            foreach (Whiskey aWhiskey in whiskeyList)
                Console.WriteLine(aWhiskey);


            
            //************************************************************************************
            //Deleting a whiskey from the list
            //************************************************************************************
            Console.WriteLine("");
            Console.WriteLine("Delete a whiskey.");
            Console.WriteLine("Enter Whiskey Brand Name: ");
            string delWhiskey = Console.ReadLine();

            whiskeyFound = false;

            for (int index = 0; index < whiskeyList.Count; index++)
            {
                if (whiskeyList[index].WBrandName == delWhiskey) 
                {
                    whiskeyList.RemoveAt(index);
                    whiskeyFound = true;
                }
            }
            if (whiskeyFound)
                Console.WriteLine(delWhiskey + " has been deleted.");
            else
                Console.WriteLine("Whiskey not found. Please try again.");

            //print list after deleting a record.
            foreach (Whiskey aWhiskey in whiskeyList)
                Console.WriteLine(aWhiskey);

            //****************************************************************************************
            //Updating an existing whiskey's rating in the list
            //****************************************************************************************
            Console.WriteLine("");
            Console.WriteLine("Update a whiskey rating.");
            Console.WriteLine("Enter Whiskey Brand Name: ");
            string updWhiskey = Console.ReadLine();
            whiskeyFound = false;

            for (int index = 0; index < whiskeyList.Count; index++)
            {
                if (whiskeyList[index].WBrandName == updWhiskey)
                {
                    Console.WriteLine("Please enter your new rating for " + updWhiskey + ": ");
                    int newRate = Convert.ToInt32(Console.ReadLine());
                    whiskeyList[index].WRating = newRate;
                    whiskeyFound = true;
                }
            }
            if (whiskeyFound)
            {
                Console.WriteLine("Whiskey rating has been updated.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Employee not found, nothing was updated.");
                Console.WriteLine("");
            }

            //print list after updating an employee
            foreach (Whiskey aWhiskey in whiskeyList)
                Console.WriteLine(aWhiskey);        
        }
    }
}