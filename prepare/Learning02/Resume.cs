using System;
using System.Collections.Generic; // I found this required for using List<Job>

namespace JobInfo
{
    // The Resume class represents a person's resume
    public class Resume
    {
        // Name property to store the name of the person
        public string Name { get; set; }
        
        // Jobs property to store a list of Job objects
        public List<Job> Jobs { get; set; }

        // Constructor to initialize the Name and create an empty list for Jobs
        public Resume(string name)
        {
            Name = name;
            Jobs = new List<Job>();
        }

        // Display method to print the resume details
        public void Display()
        {
            // Print the person's name
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Jobs:");
            
            // Iterate through the list of jobs and display each job
            foreach (Job job in Jobs)
            {
                job.Display();
            }
        }
    }
}
