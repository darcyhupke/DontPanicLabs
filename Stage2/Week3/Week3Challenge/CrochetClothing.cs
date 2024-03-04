using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Challenge
{
    public class CrochetClothing : ICrochet
    {
        public void GetPricing(float materialAmount)
        {
            Console.WriteLine("Cost of the clothing project is " + materialAmount * 5);
        }
    }
}