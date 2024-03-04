using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Challenge
{
    public class CrochetAmigurumi : ICrochet
    {
        public void GetPricing(float materialAmount)
        {
            Console.WriteLine("Cost of the amigurmi project is " + materialAmount * 4);
        }
    }
}
