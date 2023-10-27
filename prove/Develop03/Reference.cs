using System;
using System.Collections.Generic;
using System.Text;

class Reference
{
    private string reference;

    public Reference(string reference) => this.reference = reference;
    
    public override string ToString() => reference;
}