using System;
public class Circle : Shape
{
    private double _radius;
/// The constructor initializes the color and radius of the circle
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
/// The GetArea method calculates the area of the circle using the formula πr²
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}