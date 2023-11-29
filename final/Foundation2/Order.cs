using System;
using System.Collections.Generic;

class Order
{
    private List<Product> Products {get; set;}
    private Customer Customer {get; set;}

    public decimal CalculateCost()
    {
        decimal totalCost = 0;

        foreach (Product product in Products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        return $"Packing Label - {Customer.Name}'s Order";

    }

    public string GetShippingLabel()
    {
        return $"Shipping Label - {Customer.Address.GetFullAddress()}";
    }
}