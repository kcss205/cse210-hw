using System;

public class Square : Shape
{
    private double _Side;

    public Square(string color, double side) : base (color)
    {
        _Side = side;
    }

    public override double GetArea()
    {
        return _Side * _Side;
    }
}