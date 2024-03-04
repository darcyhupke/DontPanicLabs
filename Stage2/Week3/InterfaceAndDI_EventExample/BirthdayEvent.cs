using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndDI_EventExample
{
    public class BirthdayEvent : IEvent
    {
        public void GetEventPricing(int numPeople)
        {
            Console.WriteLine("Cost of the birthday is: " + numPeople * 10);
        }
    }
}
