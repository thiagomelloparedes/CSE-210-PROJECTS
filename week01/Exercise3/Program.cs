using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low. Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high. Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }
        }
    }
}