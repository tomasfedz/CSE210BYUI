using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        DisplayWelcome();

        // Get user's name
        string userName = PromptUserName();

        // Get user's favorite number
        double userNumber = PromptUserNumber();

        // Square the number
        double squaredNumber = SquareNumber(userNumber);

        // Display the result
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello, there! Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        return Console.ReadLine();
    }
// prompt the user for their favorite number and return it as a double
    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number (it can be a decimal or a negative): ");
        string input = Console.ReadLine();
        // Convert string to int with error handling
        if (double.TryParse(input, out double number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Invalid number entered. Using 0.0 as default.");
            return 0.0;
        }
    }
// calculate the square of a number and return it
    static double SquareNumber(double number)
    {
        return number * number;
    }
//
    static void DisplayResult(string name, double squared)
    {
        Console.WriteLine($"I like it! {name}, the square of your number is {squared}");
    }
}
