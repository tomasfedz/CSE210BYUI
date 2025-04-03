using System;
using System.Collections.Generic;
using System.Threading;

 
class Program
{
    static void Main(string[] args)
    {
    // list of mindfulness activities
        List<MindfulnessActivity> activities = new List<MindfulnessActivity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

// while loop for menu options
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Start {activities[i].GetType().Name.Replace("Activity", "").ToLower()} activity");
            }
            Console.WriteLine($"{activities.Count + 1}. Quit");
            Console.Write("Select a choice from the menu: ");
// check if input is valid
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > activities.Count + 1)
            {
                Console.WriteLine("Invalid choice. Press enter to continue.");
                Console.ReadLine();
                continue;
            }

            if (choice == activities.Count + 1)
                break;

            activities[choice - 1].Run();
        }
    }
}