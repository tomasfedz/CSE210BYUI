using System;


class Lecture : Event {
    private string speaker;
    private int capacity;

// Constructor for the Lecture class
    // Inherits from the Event class and initializes the speaker and capacity properties
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }


// Method to get the standard details of the event
    // Overrides the GetStandardDetails method from the Event class
    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
