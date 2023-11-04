using System;

public class Shape
{
    protected string _color;

    public Shape()
    {

    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public float GetArea()
    {
        return  -1;
    }
}