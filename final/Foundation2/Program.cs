using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.IO;

class Program
{

    static void Main(string[] args)
    {   
        List<Product> products = ReadProductsFromFile("products.txt");
        
        Customer customer = GetUserInformation();

        Order order = CreateOrder(customer, products);

        DisplayOrderInformation(order);  
    }
    static List<Product> ReadProductsFromFile(string filePath)
    {
        List<Product> products = new List<Product>();
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3 &&
                int.TryParse(parts[0], out int productId) &&
                decimal.TryParse(parts[2], out decimal price))
                {
                    Product product = new Product
                    {
                        ProductId = productId,
                        Name = parts[1],
                        Price = price
                    };

                    products.Add(product);
                }
                else
                {
                    Console.WriteLine($"Error reading the file: {line}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        return products;
    }
    static Customer GetUserInformation()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your street address: ");
        string street = Console.ReadLine();

        Console.Write("Enter your city: ");
        string City = Console.ReadLine();

        Console.Write("Enter your state/province: ");
        string stateProvince = Console.ReadLine();

        Console.Write("Enter your country: ");
        string country = Console.ReadLine();

        Address userAddress = new Address
        {
            Street = street,
            City = City,
            StateProvince = stateProvince,
            Country = country
        };

        return new Customer {Name = userName, Address = userAddress};
    }

    static Order CreateOrder(Customer customer, List<Product> products)
    {
        Order order = new Order
        {
            Products = products,
            Customer = customer
        };

        return order;
    }
    static void DisplayOrderInformation(Order order)
    {
        decimal totalCost = order.CalculateCost();
        Console.WriteLine($"Total Cost of the Order: {totalCost:C}");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
    }
}