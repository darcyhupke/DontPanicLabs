using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndDI_EventExample
{
    public class WeddingEvent : IEvent
    {
        public void GetEventPricing(int numPeople)
        {
            Console.WriteLine("Cost of the wedding is: " + numPeople * 100);
        }
        //public void SpecialEvent(string message)
        //{
        //    Console.WriteLine("Inside SpecialEvent method of Wedding event");
        //    EventToWedding(message);
        //}

        //private void EventToWedding(string message)
        //{
        //    Console.WriteLine("Method: EventToWedding, Text: ", message);
        //}
    }
}
