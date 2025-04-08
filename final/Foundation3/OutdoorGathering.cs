using System;


class OutdoorGathering : Event {
    private string weather;

// Constructor for the OutdoorGathering class
    // Inherits from the Event class and initializes the weather property
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address) {
        this.weather = weather;
    }

// Method to get the standard details of the event
    // Overrides the GetStandardDetails method from the Event class
    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }
}