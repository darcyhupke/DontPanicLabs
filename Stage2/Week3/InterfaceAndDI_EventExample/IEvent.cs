using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndDI_EventExample
{
    public interface IEvent
    {
        void GetEventPricing(int numPeople);
        //void SpecialEvent(string message);
    }
}
