using System;

namespace restaurantAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string fileName = "restaurant_ratings.txt";

            // Declare and instantiate a single Restaurant object using the default constructor
            Restaurant aRestaurant = new Restaurant();    

            // Output to show the default constructor values
            Console.WriteLine(aRestaurant);

            // Declare and instantiate a single Restaurant object using the other constructor
            Restaurant bRestaurant = new Restaurant("Asian Fusian", 3);            

            // Output to show the default constructor values
            Console.WriteLine(bRestaurant);            

            // Declare and instantiate the array of Restaurant objects
            Restaurant[] restaurantArray = new Restaurant[25];

            // Now, loop through each array element and instantiate a Restaurant object for each.
            // Note that the constructor with no parameters will be used.

            for (int index = 0; index < restaurantArray.Length; index++)
            {
                restaurantArray[index] = new Restaurant();
            }

            // Load in some test data to test both ways to assign values

            restaurantArray[1].setName("McDonalds");
            restaurantArray[1].RRating = 2;
            restaurantArray[10].setName("Lazlos");
            restaurantArray[10].RRating = 4;
            restaurantArray[20].setName("Venue");
            restaurantArray[20].RRating = 5;


            // print each restaurant to test the property gets and the toString

            for (int index = 0; index < restaurantArray.Length; index++)
            {
                if (!(((restaurantArray[index]).getName())==null))
                    Console.WriteLine(restaurantArray[index]);
            }

            // add a restaurant and rating through console
            Console.WriteLine("Add restaurant:");
            string addRest = Console.ReadLine();
            Console.WriteLine("What rate do you give " + addRest + "?");
            int addRating = Convert.ToInt32(Console.ReadLine());
            bool restaurantAdded = false;
            const int maxRecord = 25;

            for (int index = 0; index < restaurantArray.Length; index++)
            {
                if ((((restaurantArray[index]).getName())==null))
                {
                    restaurantArray[index].setName(addRest);
                    restaurantArray[index].RRating = addRating;
                    restaurantAdded = true;
                    index = maxRecord;
                }
            }
            if (restaurantAdded)
                Console.WriteLine("record has been added!");

            //Delete a restaurant
            Console.WriteLine("What restaurant would you like to delete?");
            string restToDelete = Console.ReadLine();
            bool foundDelete = false;
            for (int index = 0; index < restaurantArray.Length; index++)
                {
                    if ((restaurantArray[index]).getName == restToDelete)
                        {
                            restaurantArray[index] = " "; 
                            restaurantArray[index] = " "; 
                            foundDelete = true;
                
                        }
                    if (foundDelete)
                        break;
                }

                if (!foundDelete)
                    Console.WriteLine("Name not found!");    
                else
                    Console.WriteLine(restToDelete + " has been deleted. Select R to display an updated list");
    

            // Save to a text file
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
                        for (int index = 0; index < restaurantArray.Length; index++)
                        {
                            if (!(((restaurantArray[index]).getName())==null))
                            fileStr.WriteLine(restaurantArray[index]);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

        }//Main
    }//class
}//namespace