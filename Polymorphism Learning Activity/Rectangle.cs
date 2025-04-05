using System;
public class Rectangle : Shape
{
 // The Rectangle class inherits from the Shape class
    private double _length;
    private double _width;
// The constructor initializes the color, length, and width of the rectangle
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
// The GetArea method calculates the area of the rectangle using the formula length * width
    public override double GetArea()
    {
        return _length * _width;
    }
}