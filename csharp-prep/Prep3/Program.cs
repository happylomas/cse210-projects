using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);

        Console.Write("what is the magic number? ");
        string mnumber = Console.ReadLine();
        int number = int.Parse(mnumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int cguess = int.Parse(guess);

        if (cguess < magicNumber)
        {
            Console.WriteLine("Higer");
        }
        else if ( cguess >= magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it right!");
        }
        Console.WriteLine("cguess.Count");
    }
}