using System;

abstract class Event {
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

// Constructor for the Event class
    public Event(string title, string description, DateTime date, string time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

// Properties to get the values of the private fields
    public virtual string GetStandardDetails() {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetFullAddress()}";
    }

/// Abstract method to be implemented by derived classes
    // This method will return the full details of the event, including type-specific information
    public abstract string GetFullDetails();

    public virtual string GetShortDescription() {
        return $"{GetType().Name}: {title} on {date.ToShortDateString()}";
    }
}