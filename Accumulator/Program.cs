using System;

class Program  
{
  public static void Main(string[] args)
  {
    int numberOfNumbers = 0, numberValue = 0, numberAccumulator = 0; 

    do {
      //Prompt the user for number of number values to be entered.
      Console.WriteLine("Please enter the number of number values you need to accumulate (must be 1 to 5 values): ");

      //Obtain the number of values needed and convert to Integer
      numberOfNumbers = Convert.ToInt32(Console.ReadLine());

      //Error messge
      if (numberOfNumbers < 1 || numberOfNumbers > 5)
        {  
        Console.WriteLine("Please enter a number 1 to 5."); 
        }
    } while (numberOfNumbers < 1 || numberOfNumbers > 5);




    //Add the number values entered together and display the outcome.
    for (int i = 1; i <= numberOfNumbers; i++)
     {
       do {
         //Prompt the user to enter the number values to be entered.
         Console.WriteLine("Please enter a number value (must be -100 to 100): ");

         //Obtain the number values entered by user and convert to Integer.
         numberValue = Convert.ToInt32(Console.ReadLine());

         //Error message
         if (numberValue < -100 || numberValue > 100)
           {
           Console.WriteLine("Please enter a number -100 to 100.");
           }
       } while (numberValue < -100 || numberValue > 100);
      numberAccumulator = numberAccumulator + numberValue;
     } //end for loop

    Console.WriteLine("The Total = " + numberAccumulator);
  }
}
