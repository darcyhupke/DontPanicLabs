using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Challenge
{
    public class CrochetPotholder : ICrochet
    {
        public void GetPricing(float materialAmount)
        {
            Console.WriteLine("Cost of the potholder project is " + materialAmount * 2);
        }
    }
}
