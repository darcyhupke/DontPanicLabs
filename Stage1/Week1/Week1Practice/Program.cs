/*
Program description: This program will obtain a base and an exponent from the user, and will then print out the value of the base tabken to the exponent power.
It uses a Power Method to calculate the value. 

Programmer: Darcy Hupke
Date: 1/04/2024

Requirements:
1) The base and exponent values will be integers entered by the user.
2) Validate the number values entered. Must be >= 1.
3) Add the number values entered together and display the outcome.

Algorithm:
0) initialize finalResult to zero 
1) do
    a) Prompt the user to enter the value.
    b) Get number entered by user.
    c) If the number is less than 1, display error message.
   while number < 1.
2) for each of the number of numbers entered
    a) Get a valid number -100 to 100
      do
      i.) based on number entered, prompt the user to enter the number values.
      ii.) Get number entered by user.
      iii.) If the number is less than 1, display error message.
      while the user indicates to stop
    b) Calculate the exponent.
3) Display the Result to the screen.
*/

using System;

class Program  
{

    public static void Main(string[] args)
    {
        int resultCalc = 0, baseNum = 0, expoNum = 0;
        string response;
        //Get values and validate
        do
        {
            baseNum = InputAndValidateInteger(1,"Please enter a base number : ");
            expoNum = InputAndValidateInteger(1,"Please enter an exponent : ");

            resultCalc = Power(baseNum, expoNum);
            Console.WriteLine("The answer is " + resultCalc);
            Console.WriteLine("Would you like to enter another number? (Y/N)");
           

            response = Console.ReadLine();

        } while ((response == "Y") || (response == "y"));
        
        Console.WriteLine("Thank you");
    }

    //Method to enter and validate number values.
    static int InputAndValidateInteger (int minValue, string prompt)
    {
        int value;

        do
        {
            Console.WriteLine(prompt);
            value = Convert.ToInt32(Console.ReadLine());
            if (value < minValue)
                Console.WriteLine("Oops! The value needs to be > " + minValue);
        
        } while (value < minValue);

        return value;
    }

   //Method to get Exponent calculations.
    static int Power (int numBase, int numExponent)
    {
        var result = 1;

        for (int i = 1; i <= numExponent; i++)
        {
            result = result * numBase;

        }

        return result;
    }













/*    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the base number : ");
        var numberBase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the exponent number : ");
        var numberExpo = Convert.ToInt32(Console.ReadLine());
        var resultCalc = Power(numberBase, numberExpo);

        Console.WriteLine("Result is: " + resultCalc);
    }

   // Method to enter and validate number value. 
    static int Power (int numBase, int numExponent)
    {
        var result = 1;

        for (int i = 1; i <= numExponent; i++)
        {
            result = result * numBase;

        }

        return result;
    }
*/

}