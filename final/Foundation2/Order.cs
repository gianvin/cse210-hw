using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products
    {
        get {return _products;}
        set { _products = value;}
    }
    public Customer Customer
    {
        get {return _customer;}
        set {_customer = value;}
    }

    public decimal CalculateCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        totalCost += CalculateShippingCost();
        return totalCost;
    }

    private decimal CalculateShippingCost()
   { 
        decimal shippingCost;

        if (_customer.Address.IsInUSA())
        {
            shippingCost = 5m;
        }
        else
        {
            shippingCost = 35m;
        }
        return shippingCost;
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