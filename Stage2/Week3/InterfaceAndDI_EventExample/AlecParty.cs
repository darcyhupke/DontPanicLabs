using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndDI_EventExample
{
    public class AlecPartyEvent : IEvent
    {
        public void GetEventPricing(int numPeople)
        {
            Console.WriteLine("Cost of the Alec's party is: " + numPeople * 2500);
        }
    }
}
