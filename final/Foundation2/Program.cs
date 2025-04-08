using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Order 1: USA customer
        Address addr1 = new Address("123 Orange St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Tomas Fernandez", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "M456", 19.99m, 2));

        // Order 2: Non-USA customer
        Address addr2 = new Address("1456 Italy Rd", "Resistencia", "AR", "Argentina");
        Customer cust2 = new Customer("Sabrina Iturbe", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", "P789", 599.99m, 1));
        order2.AddProduct(new Product("Charger", "C012", 29.99m, 3));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}