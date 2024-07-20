using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "12345");
        Address address2 = new Address("456 Oak St", "Othertown", "Otherstate", "67890");
        Address address3 = new Address("789 Pine St", "Sometown", "Somestate", "11223");

        Lecture lecture = new Lecture("Science Talk", "An engaging talk on science", DateTime.Now, "10:00 AM", address1, "Dr. Jane Doe", 100);
        Reception reception = new Reception("Networking Event", "A chance to network with peers", DateTime.Now.AddDays(1), "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "A fun picnic in the park", DateTime.Now.AddDays(2), "12:00 PM", address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.FullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.ShortDescription());
            Console.WriteLine();
        }
    }
}

