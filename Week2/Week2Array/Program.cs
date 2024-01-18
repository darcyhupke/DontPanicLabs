// Problem description: Given a single-dimensional array of scores, find the minimum, maximum, and average of the scores.

/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbersArray = new int[] {66, 24, 29, 10, 48, 54, 32};
        //int numberValue = numbersArray[0]; //use for max/min
        int numberValue = 0;
        int arraySize = numbersArray.Length; //use for average
        for (int i = 0; i < numbersArray.Length; i++)
        {
        //    if (numbersArray[i] > numberValue) //max number
        //    if (numbersArray[i] < numberValue)  //min number    
        //        numberValue = numbersArray[i];           
            numberValue = numberValue + numbersArray[i];

        }
        int average = numberValue/arraySize; //use for average
        //Console.WriteLine(numberValue); //use for min/max
        Console.WriteLine(average); //use for average
    }


 
}
*/
//Problem description: Given a two-dimensional array of scores 
//(a column contains the scores for a student), find the average score for each student, 
//and the minimum, maximum and average for the class.

using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] numbersArray = {{66, 24, 29}, {10, 48, 54}};
        
        //Declare variables
        double numberTotal = 0;
        double classMin = numbersArray[0,0]; //initialize to first value from array
        double classMax = 0;
        int arraySize = numbersArray.GetLength(1); //
        
        //Console.WriteLine(numbersArray.GetLength(0));
        //Console.WriteLine(numbersArray.GetLength(1));

        int arrayFullSize = numbersArray.Length; //use for average
    
        for (int i = 0; i < numbersArray.GetLength(0); i++) //each student (row = student)
        {
            Console.Write("Student " + i+  " Average Grade: ");
            double numberValue = 0;
            for (int j = 0; j < numbersArray.GetLength(1); j++) //each grade (column = students grade)
        
            {
      
                numberValue = numberValue + numbersArray[i,j]; // numberValue for each student
                numberTotal = numberTotal + numbersArray[i,j]; // numberTotal for whole class
                if (numbersArray[i,j] > classMax) //max number
                    classMax = numbersArray[i,j];
                if (numbersArray[i,j] < classMin) //min number
                    classMin = numbersArray[i,j];
            }
            double studentAverage = numberValue/arraySize; //use for average per student
            Console.Write(studentAverage);
            Console.WriteLine();
            
        }
            double classAverage = numberTotal/arrayFullSize;
            Console.WriteLine("Class Average: " + classAverage);
            Console.WriteLine("Class Max: " + classMax);
            Console.WriteLine("Class Min: " + classMin);
    
        
    }
 
}