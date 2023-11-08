namespace NumberGuessingGameConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, I am the Number Guessing Game!");
        Console.WriteLine("I will pick a number, and you will try to guess it.");
        Console.WriteLine("Are you ready to start? (Y/N)");

        string response = Console.ReadLine();

        if (response.ToLower() == "y")
        {
            PlayGame();
        }
        else
        {
            Console.WriteLine("Game exited.");
        }
    }

    static void PlayGame()
    {
        Random random = new Random();
        int guessNumber = random.Next(1, 100);
        int attempts = 0;

        Console.WriteLine("I have chosen a number between 1 and 100. Guess it!");

        while (true)
        {
            Console.Write("Enter your guess: ");
            string response = Console.ReadLine();

            if (int.TryParse(response, out int userGuess))
            {
                attempts++;

                if (userGuess == guessNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed it right in {attempts} attempts.");
                    break;
                }
                else if (userGuess < guessNumber)
                {
                    Console.WriteLine("Sorry, the number you need to guess is lower than " + userGuess + ". Please make a higher guess.");
                }
                else
                {
                    Console.WriteLine("Sorry, the number you need to guess is higher than " + userGuess + ". Please make a lower guess.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }

        Console.WriteLine("Game over. Do you want to play again? (Y/N)");

        string playAgain = Console.ReadLine();

        if (playAgain.ToLower() == "y")
        {
            PlayGame();
        }
        else
        {
            Console.WriteLine("Game exited.");
        }
    }
}
