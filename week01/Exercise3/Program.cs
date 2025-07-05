using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 35);

            int guess;
            int numberGuesses = 0;
            do
            {
                Console.Write("What is you guess? ");
                string guessAnswer = Console.ReadLine();
                guess = int.Parse(guessAnswer);

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
                numberGuesses = numberGuesses + 1;

            } while (!(guess == magicNumber));
            Console.WriteLine($"It took you {numberGuesses} guesses.");
            Console.WriteLine();
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}