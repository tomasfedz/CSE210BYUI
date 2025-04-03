class ReflectionActivity : MindfulnessActivity
{// List of reflection prompts
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
// List of reflection questions
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
// Constructor for the ReflectionActivity class
    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
// Method to run the reflection activity
    public override void Run()
    {
        StartActivity();
        
        Random rand = new Random();
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("   You may begin in: ");
        for (int i = 5; i > 0; i--)
{
    Console.Write(i + " ");
    Thread.Sleep(1000); // or use Task.Delay(1000).Wait();
}
Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{_questions[rand.Next(_questions.Count)]}");
            ShowSpinner(5);
        }
        
        EndActivity();
    }
}