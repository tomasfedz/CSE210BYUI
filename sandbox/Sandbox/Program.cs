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

            Console.WriteLine("Guess what nuber I'm thinking between 1 and 100.");

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
                    Console.WriteLine("hmmm, higher");  // Guess is too low
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("hmmm, lower");  // Guess is too high
                }
                else
                {
                    Console.WriteLine("Nice! You guessed it!");  // Correct guess
                    Console.WriteLine($"It only took you {numberOfGuesses} guesses. Maybe next time you can do it in less");  // Output the number of attempts
                }

                // I wanted to add a loop to keep the player guessing until they get it right

            } while (guess != magicNumber); 
            
            // Ask if the player wants to play again
            Console.Write("\nWould you like to play again? (yes/no) ");
            string playAgainResponse = Console.ReadLine()?.ToLower() ?? "no";  // Handle null input and convert to lowercase
            playAgain = playAgainResponse == "yes";  // Check if the response is "yes" to continue the loop
        }

        Console.WriteLine("Thanks for playing!");  // Thank the player when the loop ends
    }
}
