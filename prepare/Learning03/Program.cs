using System;

class Program
{
    static void Main()
    {
        // Using default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Using one-parameter constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Using two-parameter constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Another example with two-parameter constructor
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Testing setters and getters
        f1.Numerator = 2;
        f1.Denominator = 3;
        Console.WriteLine(f1.GetFractionString()); // Should print "2/3"
        Console.WriteLine(f1.GetDecimalValue());   // Should print "0.6666666666666666"
    }
}