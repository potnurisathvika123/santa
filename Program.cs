using System;

class SantaGiftingSystem
{
    static void Main()
    {
       
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();       
        int correctAnswers = 0;        
        correctAnswers += AskQuestion("What is your phone number?", "1234567890");
        correctAnswers += AskQuestion("What are Your hobbies?", "music, travel");
        correctAnswers += AskQuestion("what are you studing?", "BCA");
        correctAnswers += AskQuestion("What is 2*9?", "18");
        correctAnswers += AskQuestion("What is your favourite food?", "Noodles");
        int gifts = correctAnswers; 
        Console.WriteLine($"\n{userName}, you answered {correctAnswers} questions correctly.");
        Console.WriteLine($"Santa will give you {gifts} gifts this year!");
        Console.ReadLine();
    }
    static int AskQuestion(string question, string correctAnswer)
    {
        Console.WriteLine(question);
        string userAnswer = Console.ReadLine().Trim();
        if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Correct!");
            return 1;  
        }
        else
        {
            Console.WriteLine("Incorrect.");
            return 0; 
        }
    }
}
