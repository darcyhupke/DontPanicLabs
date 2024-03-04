using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    class CalcView
    {
        public CalcView() 
        {
        }

        public double GetFirstInput()
        {
            // Ask the user to type the first number.
            Console.WriteLine("Console Calculator App");
            Console.WriteLine("\tType a number, and then press Enter: ");
            double numInput1 = double.Parse(Console.ReadLine());

            //double cleanNum1 = 0;
            //while (!double.TryParse(numInput1, out cleanNum1))
            //{
            //    Console.WriteLine("This is not valid input. Please enter an integer value: ");
            //    numInput1 = Console.ReadLine();
            //}

            return numInput1;
        }

        public double GetSecondInput()
        {                      
            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter: ");
            double numInput2 = double.Parse(Console.ReadLine());

            //double cleanNum2 = 0;
            //while (!double.TryParse(numInput2, out cleanNum2))
            //{
            //    Console.WriteLine("This is not valid input. Please enter an integer value: ");
            //    numInput2 = Console.ReadLine();
            //}

            return numInput2;
        }

        public string GetOperatorOption()
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string op = Console.ReadLine().ToLower();

            return op;
        }

        public void ShowResult(double result)
        {
            Console.WriteLine("Your result: {0:0.##}\n", result);
        }

    }
}
