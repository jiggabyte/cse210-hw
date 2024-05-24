using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        " --- Think of a time when you stood up for someone else. --- ",
        " --- Think of a time when you did something really difficult. --- ",
        " --- Think of a time when you helped someone in need. --- ",
        " --- Think of a time when you did something truly selfless. --- "
    };

    private List<string> _questions = new List<string>
    {
        "> Why was this experience meaningful to you?  ",
        "> Have you ever done anything like this before?  ",
        "> How did you get started?  ",
        "> How did you feel when it was complete?  ",
        "> What made this time different than other times when you were not as successful?  ",
        "> What is your favorite thing about this experience?  ",
        "> What could you learn from this experience that applies to other situations?  ",
        "> What did you learn about yourself through this experience?  ",
        "> How can you keep this experience in mind in the future?  "
    };

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;

        DisplayStartingMessage();
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Get Ready!");
        ShowSpinner();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt.");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
  
        Console.WriteLine("When you have something in mind, press any key to continue.");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        Console.Write("Now ponder on each of the folloing questions, as they are related to this experience.\n You may begin in: ");
        ShowCountDown();
        Console.Clear();

        while (DateTime.Now < futureTime)
        {
            foreach (string question in _questions)
            {
                Console.Write(question);
                Thread.Sleep(1000);
                ShowSpinner();
                Console.WriteLine();
            }
        }
        Console.WriteLine("End of reflection");
        DisplayEndingMessage();
    }
}
