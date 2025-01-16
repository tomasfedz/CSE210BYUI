using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list to store numbers 
        List<double> numbers = new List<double>(); //I used double  instad of int to account for decimals, if the user so chooses

        Console.WriteLine("Enter a list of numbers, and after each number press Enter and type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            // Ensure input is a valid double; prompt again if not
            double number = double.Parse(Console.ReadLine());

            if (number == 0) break;

            numbers.Add(number);
        }

        // Calculate sum 
        double sum = 0;
        foreach (double num in numbers) //foreach loop to iterate through the list
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate average 
        double average = numbers.Count > 0 ? sum / numbers.Count : 0; //numbers.count returns the number of elements in the list
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        double max = numbers.Count > 0 ? numbers.Max() : 0;
        Console.WriteLine($"The largest number is: {max}");

        // Find the smallest positive number 
        double? smallestPositive = numbers.FirstOrDefault(n => n > 0); //FirstOrDefault returns the first element that matches the condition
        foreach (double num in numbers)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine(smallestPositive.HasValue 
            ? $"The smallest positive number is: {smallestPositive}" 
            : "No positive numbers found.");

  // Find smallest negative number
        double? smallestNegative = numbers.FirstOrDefault(n => n < 0);
        foreach (double num in numbers)
        {
            if (num < 0 && (smallestNegative == null || num < smallestNegative))
            {
                smallestNegative = num;
            }
        }
        Console.WriteLine(smallestNegative.HasValue 
            ? $"The smallest negative number is: {smallestNegative}" 
            : "No negative numbers found.");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (double num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}