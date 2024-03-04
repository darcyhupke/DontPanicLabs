using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndDI_EventExample
{
    public class GraduationEvent : IEvent
    {
        public void GetEventPricing(int numPeople)
        {
            Console.WriteLine("Cost of the graduation is: " + numPeople * 25); 
        }
    }
}
