using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // This code demostract the us of if conditional statment

        Console.Write("What is your grade in percentage?");
        string scorePercent = Console.ReadLine();
        int percent = int.Parse(scorePercent);

        String grade = "";


        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }


        Console.WriteLine($"Your grade is: {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! keep it up");
        }
        else
        {
            Console.WriteLine("Try hader next time");
        }

    }
}