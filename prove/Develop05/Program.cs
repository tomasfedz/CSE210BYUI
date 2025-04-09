using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    /// List to hold all goals
    /// Total score of the player
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    static int level = 1;
    static string[] levelTitles = { "Cadet", "Star Marshall", "Space Chief Prime", "Fleet Admiral", "Admirable Admiral" };

        /// Main method to run the program
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"\nEternal Quest - Level {level} {levelTitles[Math.Min(level-1, 4)]}");
            Console.WriteLine($"Total Score: {totalScore}");
            Console.WriteLine("\n1. Display Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            //menu options
            {
                case "1": DisplayGoals(); break;
                case "2": CreateGoal(); break;
                case "3": RecordEvent(); break;
                case "4":
                    Console.Write("Name the file to save progress (press Enter for default 'progress.txt'): ");
                    string saveFilename = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(saveFilename))
                    {
                        saveFilename = "progress.txt";
                    }
                    else if (!saveFilename.EndsWith(".txt"))
                    {
                        saveFilename += ".txt";
                    }
                    SaveProgress(saveFilename);
                    break;
                case "5": LoadProgress(); break;
                case "6": return;
                default: Console.WriteLine("Invalid option"); break;
            }
        }
    }

/// Method to display all goals
    static void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

/// Method to create a new goal
    static void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type");
                return;
        }
        Console.WriteLine("Goal created successfully!");
    }

/// Method to record an event for a goal
    static void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Select goal to record (number): ");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            totalScore += pointsEarned;
            Console.WriteLine($"Recorded! Earned {pointsEarned} points!");
            
            int newLevel = totalScore / 1000 + 1;
            if (newLevel > level)
            {
                level = newLevel;
                Console.WriteLine($"Congratulations! You've reached Level {level}!");
            }
        }
    }

/// Method to save progress to a file
/// This method saves the total score, level, and all goals to a file
    static void SaveProgress(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalScore);
            writer.WriteLine(level);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Progress saved to '{filename}' successfully!");
    }

/// Method to load progress from a file
    static void LoadProgress()
    {
        Console.Write("Enter filename to load progress (press Enter for default 'progress.txt'): ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = "progress.txt";
        }
        else if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            totalScore = int.Parse(lines[0]);
            level = int.Parse(lines[1]);
            goals.Clear();

            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string[] details = parts[1].Split(',');


                switch (parts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal sg = new SimpleGoal(details[0], int.Parse(details[1]));
                        sg.SetComplete(bool.Parse(details[2]));
                        goals.Add(sg);
                        break;
                    case "EternalGoal":
                        EternalGoal eg = new EternalGoal(details[0], int.Parse(details[1]));
                        eg.SetComplete(bool.Parse(details[2]));
                        goals.Add(eg);
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal cg = new ChecklistGoal(details[0], int.Parse(details[1]), 
                            int.Parse(details[3]), int.Parse(details[5]));
                        cg.SetComplete(bool.Parse(details[2]));
                        cg.SetCurrentCount(int.Parse(details[4]));
                        goals.Add(cg);
                        break;
                }
            }
            Console.WriteLine($"Progress loaded from '{filename}' successfully!");
        }
        else
        {
            Console.WriteLine($"No saved progress found in '{filename}'!");
        }
    }
}

