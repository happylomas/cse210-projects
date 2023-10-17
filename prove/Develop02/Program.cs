using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // prompt  the user to choose an what to do
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("");
        Console.WriteLine("1. Write On Your Journal");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quite");

        string reply  = Console.ReadLine();

        // Using if statement to carry out taske base on users reply
        if (reply == "1")
        {
            Console.WriteLine("You are going to wrrite on your journal");
        }
       
        else if (reply == "2")
        {
            Console.WriteLine("You are going to display a content");
        }

         else if (reply == "3")
        {
            Console.WriteLine("You are going to load a content");
        }

         else if (reply == "4")
        {
            Console.WriteLine("You are going to save a content");
        }

        else
        {
            Console.WriteLine("You Quit, thank you");
        }

    }
}