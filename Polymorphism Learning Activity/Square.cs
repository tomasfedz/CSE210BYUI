using System;

// The Square class inherits from the Shape class
public class Square : Shape
{
    private double _side;
// The constructor initializes the color and side length of the square
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
// The GetArea method calculates the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}