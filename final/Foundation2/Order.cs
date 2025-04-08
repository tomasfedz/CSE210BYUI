using System;
using System.Collections.Generic;


public class Order
{
    private List<Product> products;
    private Customer customer;

    /// Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    /// Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    /// Method to calculate the total cost of the order
    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        foreach (Product p in products)
        {
            productTotal += p.GetTotalCost();
        }
        return productTotal + (customer.LivesInUSA() ? 5m : 35m);
    }

    /// Method to get the packing label for the order
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label.Trim();
    }

    /// Method to get the shipping label for the order
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
