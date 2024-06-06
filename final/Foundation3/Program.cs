using System;

class Program
{
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello Foundation3 World!");

       // Create an Address
        Address address = new Address("123 Main St", "New York", "NY", "USA");

        // Create an Event
        Event regularEvent = new Event("Networking Mixer", "Join us for a networking event", "2024-06-10", "18:00", address);

        // Create a Lecture
        Lecture lectureEvent = new Lecture("Machine Learning Workshop", "Learn the basics of machine learning", "2024-06-15", "10:00", address, "Dr. Smith", 50);

        // Create an Outdoor Gathering
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer BBQ", "Enjoy a summer BBQ with friends", "2024-07-05", "12:00", address, "Sunny");

        // Create a Reception
        Reception receptionEvent = new Reception("Company Anniversary Celebration", "Celebrating 10 years of success", "2024-08-20", "19:00", address, "rsvp@example.com");

        // Display marketing messages for each event
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("-------------------");

        Console.WriteLine("Regular Event:");
        Console.WriteLine(regularEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        
    }
}