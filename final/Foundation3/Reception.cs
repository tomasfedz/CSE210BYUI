using System;


class Reception : Event {
    private string rsvpEmail;

// Constructor for the Reception class
    // Inherits from the Event class and initializes the rsvpEmail property
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }


// Method to get the standard details of the event
    // Overrides the GetStandardDetails method from the Event class
    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP: {rsvpEmail}";
    }
}