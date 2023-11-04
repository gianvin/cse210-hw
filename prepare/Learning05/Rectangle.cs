using System;
using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double Width) : base (color)
    {
        _length = length;
        _width = Width;
    }
    
   
    public override double GetArea()
    {
        return _length * _width;
    }

}