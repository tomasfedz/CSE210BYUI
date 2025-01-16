using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;  // Set initial play state to true, starting the game loop
        while (playAgain)  // Continue looping as long as the player wants to play again
        {
            // Generate random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);  // Random number between 1 and 100
            int numberOfGuesses = 0;  // Track the number of guesses made

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            int guess;  // Declare the variable to hold the player's guess
            do
            {
                Console.Write("What is your guess? ");
                
                // Ensure input is a valid integer; prompt again if not
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Please enter a valid number. What is your guess? ");
                }

                numberOfGuesses++;  // Increment the guess counter

                // Compare the guess to the magic number and give feedback
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");  // Guess is too low
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");  // Guess is too high
                }
                else
                {
                    Console.WriteLine("You guessed it!");  // Correct guess
                    Console.WriteLine($"It took you {numberOfGuesses} guesses.");  // Output the number of attempts
                }
            } while (guess != magicNumber);  // Loop until the player guesses correctly
            
            // Ask if the player wants to play again
            Console.Write("\nWould you like to play again? (yes/no) ");
            string playAgainResponse = Console.ReadLine()?.ToLower() ?? "no";  // Handle null input and convert to lowercase
            playAgain = playAgainResponse == "yes";  // Check if the response is "yes" to continue the loop
        }

        Console.WriteLine("Thanks for playing!");  // Thank the player when the loop ends
    }
}
