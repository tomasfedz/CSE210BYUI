using System;

class Program
{
    static void Main()
    {
        // Ask user for grade percentage
        Console.Write("What is your grade percentage: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        // Determine letter grade
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign (+/-) for letter grade
        string sign = "";
        if (letter != "F" && letter != "A")
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93)
        {
            sign = "-";
        }

        // Print letter grade and sign 
        Console.WriteLine($"Your grade is {letter}{sign}.");

        // Determine if user passed the course or not
        if (grade >= 70)
        {
            Console.WriteLine("Good for you, you passed the course!");
        }
        else
        {
            Console.WriteLine("Aw man, Better luck next time :/");
        }

        // Pause program before closing
        Console.ReadKey();
    }
}