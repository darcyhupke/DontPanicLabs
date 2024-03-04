using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Challenge
{
    public class CrochetBlanket : ICrochet
    {
        public void GetPricing(float materialAmount)
        {
            Console.WriteLine("Cost of the blanket project is " + materialAmount * 3);
            //for testing will need to add a return
        }
    }
}