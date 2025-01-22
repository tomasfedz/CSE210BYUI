using System;
using System.Collections.Generic;

namespace JobInfo
{
    // The Job class represents a job position with a company
    public class Job
    {
        // Fields to store job details
        public string Company;    // The name of the company
        public string JobTitle;   // The title of the job
        public int StartYear;     // The year the job started
        public int EndYear;       // The year the job ended

        // Constructor to initialize the job details. Had some trial and error attempts with the constructor but finally 
        //had it to work.
        public Job(string company, string jobTitle, int startYear, int endYear)
        {
            Company = company;
            JobTitle = jobTitle;
            StartYear = startYear;
            EndYear = endYear;
        }

        // Method to display the job details
        public void Display()
        {
            // Print the job details in the format: JobTitle (Company) StartYear-EndYear
            Console.WriteLine($">>{JobTitle} ({Company}) {StartYear}-{EndYear}");
        }
    }
}
