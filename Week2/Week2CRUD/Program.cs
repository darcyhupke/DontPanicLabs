/*
Program description: This program will program that provides the user the ability to perform 
the CRUD operations on a text file that stores the name of each person in this cohort.  

Programmer: Darcy Hupke
Date: 1/09/2024

Requirements:

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
        const int arraySize=12;
        string[] nameArray = new string[arraySize];
        string fileName = "names.txt";
        

      // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("What's your pleasure? ");
                Console.WriteLine("L: Load the data file into an array.");
                Console.WriteLine("S: Save the array to the data file.");
                Console.WriteLine("C: Add a name to the array.");
                Console.WriteLine("R: Read a name from the array.");
                Console.WriteLine("U: Update a name in the array.");
                Console.WriteLine("D: Delete a name from the array.");
                Console.WriteLine("Q: Quit the program.");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
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

        //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");

                int index = 0;  // index for my array
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
				    Console.WriteLine(" Here is the content of the file names.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                       Console.WriteLine(s);
                       nameArray[index] = s; //s is next line
                       //read the rating from file
                       //put rating into array index,1
                        index = index + 1;
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
                    int index = 0;
                    using(StreamWriter fileStr = File.CreateText(fileName))
                    {
                        foreach (string name in nameArray)
                        {
                            fileStr.WriteLine(name);
                        }
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
                Console.WriteLine("Who would you like to add?");
                string addName = Console.ReadLine();
                bool nameAdded = false;

                for (int index = 0; index < arraySize; index++)
                {
                    if ((nameArray[index]) == "")
                    {
                        nameArray[index] = addName;   
                        index = arraySize;
                        nameAdded = true;
                    }    
       
                } 
                if (!nameAdded)
                {
                    Console.WriteLine("No room available! Must delete a name before you can add a new one.");    
                    Console.WriteLine("");
                }
                else
                    Console.WriteLine("Name added. Select R to display an updated list."); 
                    Console.WriteLine("");
            }

        //  TODO: Else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                for (int index = 0; index < arraySize; index++)
                {
                    if ((nameArray[index])!="")
                        Console.WriteLine(nameArray[index]);
                    else
                        Console.WriteLine("Index " + index + " is available.");
                }

            }
        //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
                Console.WriteLine(" ");
                Console.WriteLine("Who would you like to update?");
                string nameToUpdate = Console.ReadLine();
                Console.WriteLine("What would you like to change " + nameToUpdate + " to?");
                string changeNameTo = Console.ReadLine();
                bool foundUpdate = false;

                
                for (int index = 0; index < arraySize; index++)
                {
                    if ((nameArray[index]) == nameToUpdate)
                        {
                            nameArray[index] = changeNameTo;  
                            foundUpdate = true;
                
                        }
                    if (foundUpdate)
                        break;
                }

                if (!foundUpdate)
                    Console.WriteLine("Name not found!");    
                else
                    Console.WriteLine("Name updated. Select R to display an updated list.");
            }
            

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
                Console.WriteLine("Who would you like to delete?");
                string nameToDelete = Console.ReadLine();
                bool foundDelete = false;


                for (int index = 0; index < arraySize; index++)
                {
                    if ((nameArray[index]) == nameToDelete)
                        {
                            nameArray[index] = "";  
                            foundDelete = true;
                
                        }
                    if (foundDelete)
                        break;
                }

                if (!foundDelete)
                    Console.WriteLine("Name not found!");    
                else
                    Console.WriteLine(nameToDelete + " has been deleted. Select R to display an updated list");
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