using System;

namespace InterfaceAndDI_EventExample
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
            Console.WriteLine("What Event would you like a quote for? ");
            Console.WriteLine("Select the event option:");
            Console.WriteLine("W : Wedding Event Pricing");
            Console.WriteLine("B : Birthday Event Pricing");
            Console.WriteLine("G : Graduation Event Pricing");
            string input = Console.ReadLine().ToLower();
            */
            IEvent eventFile = new GraduationEvent();
            EventService eventService1 = new EventService(eventFile);
            eventService1.GetEventPricing(50);

            IEvent eventFile2 = new BirthdayEvent();
            EventService eventService2 = new EventService(eventFile2);
            eventService2.GetEventPricing(10);

            eventFile2 = new WeddingEvent();
            eventService2 = new EventService(eventFile2);
            eventService2.GetEventPricing(10);

            eventFile2 = new AlecPartyEvent();
            eventService2 = new EventService(eventFile2);
            eventService2.GetEventPricing(10);
        }
    }
}