using System;

namespace restaurantAPP
{
  class Program
  {
    static void Main(string[] args)
    { 
        // Declare and instantiate the array of Restaurant objects
        Restaurant[] restaurantArray=new Restaurant[25];

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

        // test the FineDining inheritance with default constructor
        FineDining fine1 = new FineDining();        
        Console.WriteLine(fine1);
        FineDining fine2 = new FineDining("Laslos",3,false);
        Console.WriteLine(fine2);
        fine2.RReservation = true;
        fine2.RRating = 4;
        Console.WriteLine(fine2);

        // test adding a FineDining to the restaurantArray
        restaurantArray[5]=fine1;
        restaurantArray[15]=fine2;

        
        // print each restaurant to test the property gets and the toString
        Console.WriteLine("\n\nMixing Restaurant and FineDining objects in the array.");
        for (int index = 0; index < restaurantArray.Length; index++)
        {
            if (!(((restaurantArray[index]).getName())==null))
                Console.WriteLine(restaurantArray[index]);
        }

        // test the FastFood inheritance with default constructor
        FastFood fast1 = new FastFood();
        Console.WriteLine(fast1);
        FastFood fast2 = new FastFood("Perkins",5,false);
        Console.WriteLine(fast2);
        fast2.DDriveThru = true;
        fast2.RRating = 1;
        Console.WriteLine(fast2);

        // test adding a FastFood to the restaurantArray
        restaurantArray[20] = fast1;
        restaurantArray[22] = fast2;

     
        // print each restaurant to test the property gets and the toString
        Console.WriteLine("\n\nMixing Restaurant and FastFood objects in the array.");
        for (int index = 0; index < restaurantArray.Length; index++)
        {
            if (!(((restaurantArray[index]).getName())==null))
                Console.WriteLine(restaurantArray[index]);
        }



    } // Main
  } // class
} // namespace