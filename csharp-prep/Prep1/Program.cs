using System;

class Program
{
    static void Main(string[] args)
    {
      // Prompt user for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt user for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display full name
        Console.WriteLine($"Hello, {firstName} {lastName}. My name is Tom Riddle");

        // Pause program before closing. I found this useful.
        Console.ReadKey();
    }
}