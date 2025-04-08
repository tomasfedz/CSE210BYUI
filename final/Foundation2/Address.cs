using System;
using System.Collections.Generic;


public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    /// Constructor to initialize the address fields
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    /// Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    /// Method to get the full address as a formatted string    
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}