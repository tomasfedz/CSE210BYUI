using System;
public class Fraction
{
    private int numerator;
    private int denominator;

    // Default constructor initializes to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter, denominator defaults to 1
    public Fraction(int num)
    {
        numerator = num;
        denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int num, int denom)
    {
        numerator = num;
        denominator = denom;
        // Optional: Normalize the fraction
        if (denominator != 0)
        {
            int gcd = GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Getter and Setter for Numerator
    public int Numerator 
    { 
        get => numerator; 
        set => numerator = value; 
    }

    // Getter and Setter for Denominator
    public int Denominator 
    { 
        get => denominator; 
        set 
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            denominator = value;
        }
    }

    // Method to get the string representation of the fraction
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get the decimal representation of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }

    // Helper method to calculate Greatest Common Divisor for normalization
    private int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}