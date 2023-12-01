using System;
using System.Collections.Concurrent;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Address customerAddress = new Address
        {
            Street = "456 Main St.",
            City = "Los Angeles",
            StateProvince = "California",
            Country = "United States of America"
            };

        Customer customer = new Customer
        {
            Name = "John Smith",
            Address = customerAddress
        };

        Product product = new Product
        {
          Name = "Widget",
          ProductId = 1,  
          Price = 10.99M,
          Quantity = 3
        };

        Order order = new Order
        {
            Products = new List<Product> {product},
            Customer = customer
        };

       decimal totalCost = order.CalculateCost();
       Console.WriteLine($"Total Cost of the Order: {totalCost:C}");
       Console.WriteLine(order.GetPackingLabel());
       Console.WriteLine(order.GetShippingLabel());
    }
}