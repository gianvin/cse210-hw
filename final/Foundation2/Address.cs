using System;
using System.Collections.Generic;

class Address
{
    //Fields
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string Street
    {
        get {return _street;}
        set { _street = value;}
    }
    public string City
    {
        get {return _city;}
        set { _city = value;}
    }
    public string StateProvince
    {
        get {return _stateProvince;}
        set {_stateProvince = value;}
    }
    public string Country
    {
        get {return _country;}
        set {_country = value;}
    }

    //methods
    public bool IsInUSA()
    {
        return Country.Equals("United State, StringComparison.OrdinalIgnoreCase");
    }
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }

  
}