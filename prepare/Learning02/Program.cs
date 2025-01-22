using System;

namespace JobInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Job instances with company name, job title, start year, and end year
            Job job1 = new Job("SpaceX", "Software Engineer", 2020, 2022);
            Job job2 = new Job("Qualcomm", "Data Scientist", 2016, 2020); // Fixed company name typo
            Job job3 = new Job("Tesla", "CEO", 2022, 2023);
            Job job4 = new Job("Apple", "CEO", 2010, 2025);
            Job job5 = new Job("Microsoft", "Data Scientist", 2020, 2022);

            // Creating Resume instances with the person's name
            Resume myResume = new Resume("Elon Musk");
            Resume resume2 = new Resume("Tim Cook"); // Fixed variable name casing
            Resume resume3 = new Resume("Tomas Fernandez");

            // Adding jobs to the first resume
            myResume.Jobs.Add(job1);
            myResume.Jobs.Add(job2);
            myResume.Jobs.Add(job3);

            // Adding jobs to the second and third resumes
            resume2.Jobs.Add(job4);
            resume3.Jobs.Add(job5);

            // Displaying the resumes with separators for better readability
            Console.WriteLine("==== Resume 1 ===="); 
            myResume.Display();
            Console.WriteLine();

            Console.WriteLine("==== Resume 2 ====");
            resume2.Display();
            Console.WriteLine();

            Console.WriteLine("==== Resume 3 ====");
            resume3.Display();
            Console.WriteLine();
        }
    }
}
