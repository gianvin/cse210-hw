using System;
using System.Collections.Generic;

class Customer
{
    // Fields
    public string Name { get; set;}
    public Address Address {get; set;}

    public bool IsInUSA()
    {
        return Address?.IsInUSA() ?? false;
    }
}