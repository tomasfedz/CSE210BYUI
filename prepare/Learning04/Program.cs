using System;
class Program
{
    static void Main(string[] args)
    {
            // List to store all assignments
        List<Assignment> assignments = new List<Assignment>();
        
        while (true)
        {
            // Display menu
            Console.WriteLine("\nAssignment Management Menu:");
            Console.WriteLine("1. Add Math Assignment");
            Console.WriteLine("2. Add Writing Assignment");
            Console.WriteLine("3. Display All Assignments");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddMathAssignment(assignments);
                    break;
                case "2":
                    AddWritingAssignment(assignments);
                    break;
                case "3":
                    DisplayAssignments(assignments);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1-4.");
                    break;
            }
        }
    }

    // Add a math assignment to the list
    static void AddMathAssignment(List<Assignment> assignments)
    {
        // Get student name, topic, section, and problems from user
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter topic: ");
        string topic = Console.ReadLine();
        Console.Write("Enter section (e.g., 7.3): ");
        string section = Console.ReadLine();
        Console.Write("Enter problems (e.g., 8-19): ");
        string problems = Console.ReadLine();

        // Create a new math assignment and add it to the list
        MathAssignment math = new MathAssignment(name, topic, section, problems);
        assignments.Add(math);
        Console.WriteLine("Math assignment added successfully!");
    }

    // Add a writing assignment to the list
    static void AddWritingAssignment(List<Assignment> assignments)
    {
        // Get student name, topic, and title from user
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter topic: ");
        string topic = Console.ReadLine();
        Console.Write("Enter writing title: ");
        string title = Console.ReadLine();

        // Create a new writing assignment and add it to the list
        WritingAssignment writing = new WritingAssignment(name, topic, title);
        assignments.Add(writing);
        Console.WriteLine("Writing assignment added successfully!");
    }

    // Display all assignments in the list
    static void DisplayAssignments(List<Assignment> assignments)
    {
        // Check if the list is empty
        if (assignments.Count == 0)
        {
            Console.WriteLine("No assignments to display.");
            return;
        }

        // Display all assignments
        Console.WriteLine("\nAll Assignments:");
        foreach (Assignment assignment in assignments)
        {
            // Display summary of the assignment
            Console.WriteLine(assignment.GetSummary());

            // Check if it's a math assignment
            if (assignment is MathAssignment math)
            {
                // Display homework list
                Console.WriteLine(math.GetHomeworkList());
            }
            // Check if it's a writing assignment
            else if (assignment is WritingAssignment writing)
            {
                // Display writing information
                Console.WriteLine(writing.GetWritingInformation());
            }
            Console.WriteLine(); // Blank line for readability
        }
    }
}