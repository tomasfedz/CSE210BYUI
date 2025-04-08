using System;

class Program {
    static void Main() {
        Address addr = new Address("760 Buenos Aires St", "Austin", "TX", "USA");
        Address addr2 = new Address("6999 Los Lakers Blvd", "Los Angeles", "CA", "USA");
        Address addr3 = new Address("456 Knicks St", "New York", "NY", "USA");


// Create an array of Event objects
        // Each event is of a different type (Lecture, Reception, OutdoorGathering)
        Event[] events = new Event[] {
            new Lecture("Sports Today", "Why Messi is the GOAT", DateTime.Now.AddDays(10), "2:00 PM", addr, "Dr. Fernandez", 250),
            new Reception("Gala Night", "World Cup 2022 celebration", DateTime.Now.AddDays(1), "6:00 PM", addr, "rsvp@event.com"),
            new OutdoorGathering("Picnic", "Family day steak and hotdogs", DateTime.Now.AddDays(2), "10:00 AM", addr, "Overcast"),
            new OutdoorGathering("Beach Party", "Fun in the sun", DateTime.Now.AddDays(3), "11:00 AM", addr2, "Sunny"),
            new Lecture ("Tech Talk", "The future of AI", DateTime.Now.AddDays(4), "1:00 PM", addr3, "Mr. Smith", 100),
        };

// Iterate through each event and print its details
        // For each event, print the standard details, full details, and short description
        foreach (Event e in events) {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n-------------------\n");
        }
    }
}