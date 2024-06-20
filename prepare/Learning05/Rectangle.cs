using System;

public class Rectangle : Shape
{
    private double _Lenght;
    private double _Width;

    public Rectangle(string color, double lenght, double width) : base (color)
    {
        _Lenght = lenght;
        _Width = width;
    }

    public override double GetArea()
    {
        return _Lenght * _Width;
    }
}