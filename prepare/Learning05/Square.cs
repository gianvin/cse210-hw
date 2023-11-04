using System;

public class Square : Shape
{
    protected float _side = 0;
    private float _area = 0;

    public float GetSide()
    {
       return _side; 
    }
    public void SetSide(float side)
    {
        _side = side;
    }
    public override float GetArea()
    {
        return base.GetArea();
    }

}