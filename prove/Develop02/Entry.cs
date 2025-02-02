// Tomas Fernandez CSE 210 
// Unit 02 Develop: Journal Program

using System;

namespace JournalingProgram
{
    public class Entry
    { 
        // Properties for the Entry class
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
             // Constructor for the Entry class
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
             // Method to display the entry as a string
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }

        public string ToFileString()
        {
            // Method to format the entry for saving to a file
            return $"{Prompt}~{Response}~{Date}";
        }
    }
}