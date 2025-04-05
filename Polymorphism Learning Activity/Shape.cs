using System;
// This is the base class for all shapes
public class Shape
{
/// The color of the shape
    // The Shape class serves as a base class for different shapes
    private string _color;

/// The constructor initializes the color of the shape
    // The constructor takes a color parameter and sets the _color field
    public Shape(string color)
    {
        _color = color;
    }
/// The GetColor method returns the color of the shape
    public string GetColor()
    {
        return _color;
    }
/// The SetColor method allows changing the color of the shape
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0; // Base implementation, to be overridden
    }
}