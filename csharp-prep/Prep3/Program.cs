using System;

class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        int count = 0;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            count = count + 1 ;
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("It's Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("It's Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it!  It took you {count} guesses!");
            }
        }

    }
}