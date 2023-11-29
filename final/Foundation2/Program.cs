using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress = new Address
        {
            Street = "456 Main St.",
            City = "Los Angeles",
            StateProvince = "California";
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
          ProductId = "1",  
          Price = "$ 10.99",
          Quantity = 3
        };

        Order order = new Order
        {
            Products = new List<Product> { Product },
            Customer = customer
        };

       decimal totalCost = order.CalculateTotalCost();
       Console.WriteLine($"Total Cost of the Order: {totalCost:C}");
       Console.WriteLine(order.GetPackingLabel());
       Console.WriteLine(Order.GetShippingLabel());
    }
}