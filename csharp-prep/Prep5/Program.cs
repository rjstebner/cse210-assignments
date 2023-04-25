using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();

        string userName = GatherName();
        int userNumber = GatherNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);

    }
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string GatherName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }
     static int GatherNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}