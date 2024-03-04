using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndDI_EventExample
{
    public class EventService
    {
        private readonly IEvent _event;
        public EventService(IEvent anEvent)
        {
            _event = anEvent;
        }
        public void GetEventPricing(int numPeople)
        {
            _event.GetEventPricing(numPeople);
        }
    }
}
