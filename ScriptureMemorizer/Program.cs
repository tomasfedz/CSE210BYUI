using System;
using System.Collections.Generic;
using System.Linq;

// Class representing the program
class Program
{
    // Dictionary storing scripture references and texts, grouped by source
    static readonly Dictionary<string, List<(Reference reference, string text)>> ScriptureLibrary = new Dictionary<string, List<(Reference, string)>>
    {
        // Book of Mormon scriptures
        {
            "Book of Mormon", new List<(Reference, string)>
            {
                // 1 Nephi 3:7
                (new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
                
                // Alma 7:11
                (new Reference("Alma", 7, 11), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."),
                // Moroni 10:4
                (new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            }
        },
        // Bible scriptures
        {
            "Bible", new List<(Reference, string)>
            {
                // John 3:16
                (new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son that whosoever believeth in him should not perish, but have everlasting life."),
                // Proverbs 3:5-6
                (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
                // Matthew 5:16
                (new Reference("Matthew", 5, 16), "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.")
            }
        },
        // Doctrine and Covenants
        {
            "Other", new List<(Reference, string)>
            {
                // Doctrine and Covenants 18:10
                (new Reference("Doctrine and Covenants", 18, 10), "Remember the worth of souls is great in the sight of God."),
                // Doctrine and Covenants 121:7-8
                (new Reference("Doctrine and Covenants", 121, 7, 8), "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment; And then, if thou endure it well, God shall exalt thee on high; thou shalt triumph over all thy foes.")
            }
        }
    };

    // Main program entry point
    static void Main()
    {
        // Continuously prompt user for input until they choose to quit
        while (true)
        {
            // Clear console and display main menu
            Console.Clear();
            Console.WriteLine("Welcome to Scripture Memorizer");
            Console.WriteLine("1. Book of Mormon");
            Console.WriteLine("2. Bible");
            Console.WriteLine("3. Other Scriptures");
            Console.WriteLine("4. Quit");
            Console.Write("Choose a scripture source: ");
            string sourceChoice = Console.ReadLine() ?? string.Empty;

            // Handle quit option
            if (sourceChoice == "4")
            {
                Console.WriteLine("Program ending.");
                return;
            }

            // Map user input to scripture source
            string source = sourceChoice switch
            {
                "1" => "Book of Mormon",
                "2" => "Bible",
                "3" => "Other",
                _ => string.Empty
            };

            // Validate user input
            if (source == null || !ScriptureLibrary.ContainsKey(source))
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }

            // Display scripture options and get user choice
            var scriptures = ScriptureLibrary[source];
            Console.Clear();
            Console.WriteLine($"Available scriptures from {source}:");
            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].reference}");
            }
            Console.Write("Choose a scripture by number: ");
            if (!int.TryParse(Console.ReadLine(), out int scriptureChoice) || scriptureChoice < 1 || scriptureChoice > scriptures.Count)
            {
                Console.WriteLine("Invalid selection. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }

            // Create Scripture object and start game
            var selectedScripture = scriptures[scriptureChoice - 1];
            Scripture scripture = new Scripture(selectedScripture.reference, selectedScripture.text);
            RunScriptureGame(scripture);

            // Prompt user to choose another scripture or quit
            Console.WriteLine("\nPress Enter to choose another scripture, or type 'quit' to exit.");
            if (Console.ReadLine()?.ToLower() == "quit") break;
        }
    }

    // Run the scripture memorization game
    static void RunScriptureGame(Scripture scripture)
    {
        // Continue game until all words are hidden
        while (!scripture.AllWordsHidden())
        {
            // Clear console and display scripture
            Console.Clear();
            scripture.Display();

            // Display game menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Hide one word");
            Console.WriteLine("2. Quit to menu");

            // Get user input
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine() ?? string.Empty;

            // Handle user input
            switch (input)
            {
                case "1":
                    // Hide a random word
                    scripture.HideRandomWords(1);
                    break;
                case "2":
                    // Quit game and return to main menu
                    Console.WriteLine("Returning to main menu.");
                    return;
                default:
                    // Invalid input, prompt user to try again
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        // All words are hidden, display completion message
        Console.Clear();
        Console.WriteLine("All words hidden.");
    }
}