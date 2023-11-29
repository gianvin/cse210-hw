using System;
using System.Collections.Generic;

class Address
{
    //Fields
    public string Street {get; set;}
    public string City {get; set;}
    public string StateProvince {get; set;}
    public string Country {get; set;}

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