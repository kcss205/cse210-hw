using System;

public abstract class Shape
{
    private string _Color;

    public Shape(string color)
    {
        _Color = color;

    }

    public string GetColor()
    {
        return _Color;
    }

    public void SetColor(string color)
    {
        _Color = color;
    }

    public abstract double GetArea();
}