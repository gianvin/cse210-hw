using System;
using System.Collections.Generic;

class Customer
{
    // Fields
    private string Name { get; set;}
    private Address Address {get; set;}

    public bool IsInUSA()
    {
        return Address?.IsInUSA() ?? false;
    }
}