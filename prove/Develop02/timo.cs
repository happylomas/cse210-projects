using System;
using System.IO;

class UserAnswers
{
    public string[] Answers { get; set; }
    public DateTime Timestamp { get; set; }

    public UserAnswers()
    {
        Answers = new string[5];
        Timestamp = DateTime.Now;
    }
}

class Programe
{
    static void Main()
    {
        string filePath = "answers.txt"; // Path to the file to store answers

        // Prompt the user for 5 questions
        string[] questions = {
            "What was the most important thing you did today?",
            "Did you have a service opportunity?",
            "Did you have an experience where the Hand of the Lord was guiding you?",
            "What one thing would you do differently today, if you could do it all over?",
            "Why was today special?"
        };

        UserAnswers userAnswers = new UserAnswers();

        Console.WriteLine("Please answer the following questions:");

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            userAnswers.Answers[i] = Console.ReadLine();
        }

        // Create or append to the file with date timestamps
        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine($"Answers recorded on: {userAnswers.Timestamp}");
            for (int i = 0; i < questions.Length; i++)
            {
                writer.WriteLine($"{questions[i]}");
                writer.WriteLine($"Answer: {userAnswers.Answers[i]}");
                writer.WriteLine(); // Add a blank line for separation
            }
        }

        Console.WriteLine("Answers recorded and saved to file.");
    }
}
