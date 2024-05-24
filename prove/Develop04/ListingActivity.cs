using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        " --- Who are people that you appreciate? --- ",
        " --- What are personal strengths of yours? --- ",
        " --- Who are people that you have helped this week? --- ",
        " --- When have you felt the Holy Ghost this month? --- ",
        " --- Who are some of your personal heroes? --- "
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by listing items.")
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

        Console.WriteLine("List as many responses that you can for the following prompt.");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.Write("Get ready to list items...");
        ShowCountDown();

        Console.WriteLine("Start listing items:");

        List<string> listEntries = new List<string>();

        while (DateTime.Now < futureTime)
        {
            
            int counter = _duration;
            while(counter > 0)
            {
                Console.Write("> ");
                listEntries.Add(Console.ReadLine());
                counter--;
            }            
        }

        Console.WriteLine($"You listed {listEntries.Count} items.");
        ShowSpinner();
        Console.WriteLine("End of listing");
        DisplayEndingMessage();
    }
}
