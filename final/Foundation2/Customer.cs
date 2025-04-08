using System;
using System.Collections.Generic;

public class Customer
{
    private string name;
    private Address address;

    /// Constructor to initialize the customer fields
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    /// Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    /// Method to get the customer's name
    public string GetName() { return name; }
    public Address GetAddress() { return address; }
}