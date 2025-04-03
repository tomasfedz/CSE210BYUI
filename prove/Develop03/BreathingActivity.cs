class BreathingActivity : MindfulnessActivity
{
    // Constructor for the BreathingActivity class
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Method to run the breathing activity
    public override void Run()
    {
        StartActivity();
        
        int cycles = _duration / 8; // 4 seconds in, 4 seconds out
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        
        EndActivity();
    }
}
