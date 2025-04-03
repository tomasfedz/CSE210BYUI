class ListingActivity : MindfulnessActivity
{
    // List of prompts for the listing activity
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

// Constructor for the ListingActivity class
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

// Override the Run method to run the listing activity
    public override void Run()
    {
        StartActivity();
        
        Random rand = new Random();
        Console.WriteLine($"\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
{
    Console.Write(i + " ");
    Thread.Sleep(1000); // or use Task.Delay(1000).Wait();
}
Console.WriteLine();
// Get user input
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }
        
        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndActivity();
    }
}
