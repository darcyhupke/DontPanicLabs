/*
Program description: This program will use a Method to input number values and display outcome.
Programmer: Darcy Hupke
Date: 1/2/2024

Requirements:
1) The number of number values will be an integer entered by the user. Must be 1 to 5.
2) Based on the quantiy they selected, validate the the number values entered. Must be -100 to 100
3) Add the number values entered together and display the outcome.
*/

using System;

class Program  
{


    public static void Main(string[] args)
    {
       int numberOfNumbers = 0, numberValue = 0, numberTotal = 0; 

        numberOfNumbers = InputAndValidateInteger(1,5,"Please enter a number ");

        //Get values and display outcome
        for (int i = 1; i <= numberOfNumbers; i++)
        {
            numberValue = InputAndValidateInteger(-100,100,"Please enter a number ");
            numberTotal += numberValue;

        }//end for loop

        Console.WriteLine("The Total = " + numberTotal);
    
   }

    
    static int InputAndValidateInteger (int minValue, int maxValue, string prompt)
    {
        int value;

        do
        {
            Console.WriteLine(prompt + "between " + minValue + " and " + maxValue);
            value = Convert.ToInt32(Console.ReadLine());
            if ((value < minValue) || (value > maxValue))
                Console.WriteLine("Oops! The value needs to be between " + minValue + " and " + maxValue);
        
        } while ((value < minValue) || (value > maxValue));

        return value;
    }
}