abstract class MindfulnessActivity
{
    protected string _name; //protected because it will be used in derived classes
    protected string _description;
    protected int _duration;

// StartActivity method
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

// EndActivity method
    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity");
        ShowSpinner(3);
    }

// Show spinner and countdown animations for the activities
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int iterations = seconds * 4;
        for (int i = 0; i < iterations; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r ");
    }
// Show countdown method
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r  ");
    }

    public abstract void Run();
}
