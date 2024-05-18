using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain;

        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            } while (guess != magicNumber);

            Console.WriteLine("You guessed it! It took you {0} guesses.", guessCount);

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain.ToLower() == "yes");
    }
}