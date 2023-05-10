using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber = -1;
        while (usernumber!=0)
        {
            Console.Write("Enter a number to add to the list, enter 0 to quit:");
            string userinput = Console.ReadLine();
            usernumber = int.Parse(userinput);

            if (usernumber !=0)
            {
                numbers.Add(usernumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest number is: {min}");

        Console.WriteLine("The number in descending  or are: ");

        numbers.Sort((a,b) =>b.CompareTo(a));
        foreach (int number in numbers) 
        {
            Console.Write($"{number} ");
        }




    }
}