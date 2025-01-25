// Tomas Ferdandez CSE 210 
// Unit 02 Develop: Journal Program

using System;
using System.Collections.Generic;
using System.IO;

namespace JournalingProgram
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Create journal object
            Journal journal = new Journal();

            while (true)
            {
                //Journal menu
                Console.WriteLine("");
                Console.WriteLine("My Journal");
                Console.WriteLine("<------------------->");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                //User input of menu option
                Console.Write("Please choose from these options: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        journal.WriteNewEntry();
                        break;
                    case 2:
                        journal.DisplayJournal();
                        break;
                    case 3:
                        journal.SaveJournalToFile();
                        break;
                    case 4:
                        journal.LoadJournalFromFile();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                    //Invalid option, request new entry
                        Console.WriteLine("Invalid option. Please enter a valid option from the menu.");
                        break;
                }
            }
        }
    }
}