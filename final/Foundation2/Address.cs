using System;
using System.Collections.Generic;

class Address
{
    //Fields
    private string Street {get; set;}
    private string City {get; set;}
    private string StateProvince {get; set;}
    private string Country {get; set;}

    //methods
    public bool IsInUSA()
    {
        return Country.Equals("United Satate, StringComparison.OrdinalIgnoreCase");
    }
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}. {Country}";
    }

}