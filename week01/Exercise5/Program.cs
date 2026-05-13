using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);
    }

    // FUNCTION 1
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // FUNCTION 2
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }


    // FUNCTION 3
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // FUNCTION 4
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // FUNCTION 5
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square} ");
    }
}