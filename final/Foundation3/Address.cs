using System;

class Address {
    private string street;
    private string city;
    private string state;
    private string country;

// Constructor for the Address class
    public Address(string street, string city, string state, string country) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

// Properties to get the values of the private fields
// method to get the full address as a string
    public string GetFullAddress() {
        return $"{street}, {city}, {state}, {country}";
    }
}