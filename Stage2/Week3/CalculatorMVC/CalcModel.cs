using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcModel
    {
        public double Input1
        { get; set; }

        public double Input2 
        { get; set; }

        
        public CalcModel() 
        {
            Input1 = 0;
            Input2 = 0;
            //Operator = "";
            //Result = 0;
        }

        public CalcModel (double newInput1, double newInput2)
        {
            Input1 = newInput1;
            Input2 = newInput2;
           
        }

        public double CalculateResult(string Operator)
        {
            if (Operator ==)
            return Result; 
        }
    }
}
