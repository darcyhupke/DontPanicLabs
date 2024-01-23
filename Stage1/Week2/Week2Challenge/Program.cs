/*
Program description: This program will maintain a list of the restaurants at which you have dined, 
with their ratings.

Programmer: Darcy Hupke
Date: 1/11/2024

Requirements:
*   You want to keep track of the name and your review of restaurants (0-5 stars) and you want it to be persistent (stored in a text file).  
    Provide room for 25 restaurants.
*   You want a menu that will provide you the options of doing the following:
        L - Load the user's list of restaurants and ratings (from a data file into a data structure),
        S - Save the user's list of restaurants (from a data structure to a data file)
            Bonus - save them so there are no blank lines in the data file 
        C - Add a restaurant and rating,
            Make sure the user provides both a restaurant and rating
            Make sure to handle the "file full" case
        R - Print a list of all the restaurants and their rating,
            Bonus - only print a list of the restaurants and ratings - no blank lines in your list
            Make sure to handle the case where there are no restaurants in the list
        U - Update the rating for a restaurant, (Bonus: Update the restaurant name)
        D - Delete a restaurant
        Q - Quit the program
Algorithm:
*/

using System;
using System.IO;
using System.Linq;


namespace Crud
{
  class Program
  {
    static void Main(string[] args)
    {
        
        // Declare variables
        bool userChoice;
        string userChoiceString;
        const int rowSize=25;
        const int colSize=2;
        string[,] restaurantArray = new string[rowSize,colSize];
        string fileName = "restaurant.txt";
        string fileNameOut = "restaurant_out.txt";
        
        for (int indexRow = 0; indexRow < rowSize; indexRow++)
        {
            restaurantArray[indexRow,0] = " ";
            restaurantArray[indexRow,1] = " ";
        }


      // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("Top 25 Restaurants. ");
                Console.WriteLine("L: Load your Restaurant File.");
                Console.WriteLine("S: Save the File.");
                Console.WriteLine("C: Add a Restaurant with its Rating.");
                Console.WriteLine("R: Display the Restaurant List.");
                Console.WriteLine("U: Update the Restaurant Ratings.");
                Console.WriteLine("D: Delete a Restaurant.");
                Console.WriteLine("Q: Quit the program.");
                Console.WriteLine("");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                              userChoiceString == "S" || userChoiceString == "s" ||
                              userChoiceString == "C" || userChoiceString == "c" ||
                              userChoiceString == "R" || userChoiceString == "r" ||
                              userChoiceString == "U" || userChoiceString == "u" ||
                              userChoiceString == "D" || userChoiceString == "d" ||
                              userChoiceString == "Q" || userChoiceString == "q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l then load the text file into the array of strings (restaurantArray)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");
                
                int indexRow = 0;  // index for restaurant (rows) in array
                //int indexCol = 0;  // index for rating (cols) in array
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
            
				    Console.WriteLine(" Here is the content of the file restaurant.txt : ");
                    while ((s = sr.ReadLine()) != null) //read from file. s = each line in file
                    {
                        //split each line on the comma into array called sides
                        string[] sides=s.Split(',');
                        restaurantArray[indexRow,0] = sides[0]; // changing 114 and 115...restaurantArray[index].setName(sides[0])
                        restaurantArray[indexRow,1] = sides[1]; //restaurantArray[index].RRating = sides[1]
                       
                        Console.WriteLine(s); //display file rows
                        indexRow++;
                    }
                    Console.WriteLine("");
                }
            
            }

        //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area");

                try
                {
                    // If file exists, delete it.
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    // Create the file
                    using(StreamWriter fileStr = File.CreateText(fileName))
                    {        
                        for (int indexRow = 0; indexRow < rowSize; indexRow++)
                        {
                       
                            string rest = restaurantArray[indexRow,0];   
                            string rate = restaurantArray[indexRow,1];
                            fileStr.WriteLine(rest + "," + rate);       
                         
                           
                        }                
                        //foreach (string rest in restaurantArray)
                        //{
                        //    fileStr.WriteLine(rest);
                        //}
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                
            }


        //  TODO: Else if the option is a C or c then add a name to the array (if there's room there)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
                Console.WriteLine(" ");
                Console.WriteLine("What restaurant would you like to add?");
                string addRest = Console.ReadLine();
                Console.WriteLine("What rating do you give " + addRest + "?");
                string addRating = Console.ReadLine();
                bool restAdded = false;

                for (int indexRow = 0; indexRow < rowSize; indexRow++)
                {
                    if ((restaurantArray[indexRow,0]) == " ")
                    {
                        restaurantArray[indexRow,0] = addRest;   
                        restaurantArray[indexRow,1] = addRating;
                        indexRow = rowSize;
                        restAdded = true;
                    }           
                } 
                if (!restAdded)
                {    
                    Console.WriteLine("No room available! Must delete a restaurant before you can add a new one.");    
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Record has been added. Select R to display an updated list."); 
                    Console.WriteLine("");
                }
                
            }


        //  TODO: Else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                
                for (int indexRow = 0; indexRow < rowSize; indexRow++)
                {
                    if ((restaurantArray[indexRow,0])!=" ")
                        Console.WriteLine(restaurantArray[indexRow,0] + " has a rating of " + restaurantArray[indexRow,1]);
                    else
                        Console.WriteLine("Index " + indexRow + " is available.");
                }    
                Console.WriteLine(" ");            
            }


        //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
                Console.WriteLine(" ");
                Console.WriteLine("What restaurant record would you like to update?");
                string restToUpdate = Console.ReadLine();               
                Console.WriteLine("What would you like to change the rating to?");
                string changeRateTo = Console.ReadLine();
                bool foundUpdate = false;

                
                for (int indexRow = 0; indexRow < rowSize; indexRow++)
                {
                    if ((restaurantArray[indexRow,0]) == restToUpdate)
                    {
                        restaurantArray[indexRow,1] = changeRateTo;
                    
                        foundUpdate = true;
                    }
                   
                    if (foundUpdate)
                        break;
                }

                if (!foundUpdate)
                    Console.WriteLine(restToUpdate + " not found!");    
                else
                    Console.WriteLine("Rating updated. Select R to display an updated list.");   

                Console.WriteLine(" ");
            }
            

        //  TODO: Else if the option is a D or d then delete the restaurant in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
                Console.WriteLine("What restaurant would you like to delete?");
                string nameToDelete = Console.ReadLine();
                bool foundDelete = false;


                for (int indexRow = 0; indexRow < rowSize; indexRow++)
                {
                    if ((restaurantArray[indexRow,0]) == nameToDelete)
                        {
                            restaurantArray[indexRow,0] = " "; 
                            restaurantArray[indexRow,1] = " "; 
                            foundDelete = true;
                
                        }
                    if (foundDelete)
                        break;
                }

                if (!foundDelete)
                    Console.WriteLine("Name not found!");    
                else
                    Console.WriteLine(nameToDelete + " has been deleted. Select R to display an updated list");

                Console.WriteLine(" ");
                    
            }


        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    }  // end main
  }  // end program
}  // end namespace