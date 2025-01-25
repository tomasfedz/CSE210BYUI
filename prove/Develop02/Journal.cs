// Tomas Ferdandez CSE 210 
// Unit 02 Develop: Journal Program

using System;
using System.Collections.Generic;

namespace JournalingProgram
{
    public class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            // Initialize the journal with an empty list of entries
            entries = new List<Entry>();
        }

        public void WriteNewEntry()
        {
            // Prompt the user for a new entry
            Console.WriteLine("Write a new entry:");
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();
            Entry entry = new Entry(prompt, response, DateTime.Now.ToString("yyyy-MM-dd"));
            entries.Add(entry);
        }

        public void DisplayJournal()
        {
            // Display all entries in the journal
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void SaveJournalToFile()
        {
            // Saving my thoughts to disk, one entry at a time, with a time stamp!
            Console.Write("Enter a base filename (without extension): ");
            string baseFilename = Console.ReadLine();
            string defaultPath = @"C:\Users\tomas\OneDrive\BYU- Idaho\CSE 210\CSE210BYUI\prove\Develop02\";
            string dateStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Format: YYYYMMDD_HHmmss
            string filename = $"{baseFilename}_{dateStamp}.txt";
            string filePath = Path.Combine(defaultPath, filename);
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine($"File saved successfully to {filePath}");
        }

public void LoadJournalFromFile()
{
    // Load journal entries from a file
    Console.Write("Enter the file path (including filename): ");
    string filePath = Console.ReadLine();
    if (File.Exists(filePath))
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('~');
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }
        Console.WriteLine($"File loaded successfully from {filePath}");
    }
    else
    {
        Console.WriteLine($"File not found: {filePath}");
    }
}

        private string GetRandomPrompt()
        {
              // Let's shake up the introspection with a random question
            string[] prompts = new string[]
            {
                "What was the highlight of my day?",
                "What task took the most effort today?",
                "How did I exercise self-discipline today?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "How did I experience a blessing today?",
                "How did I respond to external events outside of my control?",
                "What am I grateful for today?",
                "What lesson did I learn from today's adversity?"
            };
            Random random = new Random();
            return prompts[random.Next(prompts.Length)];
        }
    }
}