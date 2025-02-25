using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;




class Scripture
{
    private Reference Reference { get; } // Stores the scripture reference
    private List<Word> Words { get; } // List of words in the scripture text
    private Random RandomGenerator { get; } // Random instance for selecting words to hide

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList(); // Convert text into Word objects
        RandomGenerator = new Random();
    }

    public void Display()
    {
        Console.WriteLine(Reference); // Print scripture reference
        Console.WriteLine(string.Join(" ", Words)); // Print scripture text with hidden words
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList(); // Get words that are still visible
        
        if (visibleWords.Count == 0) return; // Exit if no words are left to hide
        
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = RandomGenerator.Next(visibleWords.Count); // Pick a random visible word
            visibleWords[index].Hide(); // Hide the selected word
            visibleWords.RemoveAt(index); // Remove from visible list to avoid rehiding
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden); // Check if all words are hidden
    }
}