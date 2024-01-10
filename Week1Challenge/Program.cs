/*
Program description: This program will calculate individual student grades.

Programmer: Darcy Hupke
Date: 1/04/2024

Requirements:
1) The instructor will provide the number of students for which grades need to be calculated.  This number must be at least one.
2) For each student, the instructor will provide five homework grades, three quiz grades, and two exam grades.  All grades must be between 0 and 100 inclusively.
3) A student's final grade average is calculated by adding together 50% of the homework average, 30% of the quiz average and 20% of the exam average.
4) A student's final grade is calculated  based on the final grade average.  If it is 90% or greater, it is an A; 80% or better is a B; 70% or better is a C; 
60% or better is a D; and anything less than 60% is an F.
5) Once calculated, the program will display the student's name, homework average, quiz average, exam average, final average and final grade.

Algorithm
1) initialize variables
2) do
    a) Prompt user to enter the number of students.
    b) Get the number entered by user.
    c) If the number is less than 1, display error 
    while (number of student < 1)
3) for each number of students entered
    a) initialize variables
    b) prompt to enter student name
    c) Get homework grades
        do
        i) prompt user to enter homework grades
        ii) enter homework grades
        iii) if < 0 or > 100, display error
        while number is <= 5
    d) Get quiz grades
        do
        i) prompt user to enter quiz grades
        ii) enter quiz grades
        iii) if < 0 or > 100, display error
        while number is <= 3
    e) Get exam grades
        do
        i) prompt user to enter exam grades
        ii) enter exam grades
        iii) if < 0 or > 100, display error
        while number is <= 2    
    f) calculate grade averages
    g) display student name, grades averages, and letter grade.
*/

using System;

class Program  
{


    public static void Main(string[] args)
    {
        int numberOfStudents = 0, numberValue = 0, numberTotal = 0; 
        int homeworkValue = 0, quizValue = 0, examValue = 0; 
        
        string nameOfStudent;

        do
        {
        //Prompt the user for number of students that need grades entered.
        Console.WriteLine("Please enter the number of students you need to enter grades for: ");

        //Obtain the number of values needed and convert to Integer
        numberOfStudents = Convert.ToInt32(Console.ReadLine());

        //Error messge
        if (numberOfStudents < 1)
            {  
            Console.WriteLine("Please enter a valid number. Must be 1 or greater."); 
            }
        } while (numberOfStudents < 1);

        for (int i = 1; i <=numberOfStudents; i++)
        {
            int homeworkAccum = 0, quizAccum = 0, examAccum = 0;
            int homeworkAve = 0, quizAve = 0, examAve = 0;
            int homeworkWeightPercent = 50, quizWeightPercent = 30, examWeightPercent = 20;

            //Prompt the user to enter name of student.
            Console.WriteLine("Please enter student's name: ");
            nameOfStudent = Console.ReadLine();

            int h = 0;
            do
            {
                homeworkValue = InputAndValidateInteger(0,100,"Please enter homework grade: ");
                homeworkAccum = homeworkAccum + homeworkValue;
                h++;
            } while ((h < 5));
         //   Console.WriteLine("Homework value: " + homeworkAccum);


            int q = 0;
            do
            {
                quizValue = InputAndValidateInteger(0,100,"Please enter quiz grade: ");
                quizAccum = quizAccum + quizValue;
                q++;
            } while ((q < 3));
          //  Console.WriteLine("Quiz value: " + quizAccum);

            int e = 0;
            do
            {
                examValue = InputAndValidateInteger(0,100,"Please enter exam grade: ");
                examAccum = examAccum + examValue;
                e++;
            } while ((e < 2));
            Console.WriteLine("Grades for " + nameOfStudent);
            homeworkAve = (homeworkAccum / 5);
            Console.WriteLine("Homework value: " + homeworkAve);
            quizAve = (quizAccum / 3);
            Console.WriteLine("Quiz value: " + quizAve);
            examAve = (examAccum / 2);
            Console.WriteLine("Exam value: " + examAve);
            double weightTotal = ((homeworkWeightPercent * homeworkAve) +
                                  (quizWeightPercent * quizAve) +
                                  (examWeightPercent * examAve));
            double finalAve = (weightTotal / 100);
            Console.WriteLine("Final Average: " + finalAve);

            if (finalAve > 89)
                {
                    Console.WriteLine("Final Grade for " + nameOfStudent + " is an A.");
                }

                else if (finalAve > 79)
                {
                    Console.WriteLine("Final Grade for " + nameOfStudent + " is a B.");
                }

                else if (finalAve > 69)
                {
                    Console.WriteLine("Final Grade for " + nameOfStudent + " is a C.");
                }

                else if (finalAve > 59)
                {
                    Console.WriteLine("Final Grade for " + nameOfStudent + " is a D.");
                }

                else 
                {
                    Console.WriteLine("Final Grade for " + nameOfStudent + " is an F.");
                }
                

        }  

       // Console.WriteLine("Student name: " + nameOfStudent);
       // Console.WriteLine("Homework value: " + homeworkAccum);  
    }

    //method for validating grade input 
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