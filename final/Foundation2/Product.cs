using System;
using System.Collections.Generic;

public class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quantity;

    /// Constructor to initialize the product fields
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    /// Method to get the total cost of the product (price * quantity)
    public decimal GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    /// Method to get the product name
    public string GetName() { return name; }
    public string GetProductId() { return productId; }
}
