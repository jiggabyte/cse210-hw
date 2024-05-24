using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Starting {_name} activity:");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        try
        {
            _duration = Convert.ToInt32(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine("You entered a wrong entry for duration, Plese type a number or the program will terminate!");
            try
            {
                _duration = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Exiting the Mindfulness App. Goodbye!");
                Environment.Exit(0);
            }
        }
        
        Console.WriteLine($"Prepare to begin {_name}...");
        ShowSpinner();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You've completed the {_name} activity.");
        Console.WriteLine($"Total duration: {_duration} seconds");
        ShowSpinner();
    }

    public void ShowSpinner()
    {
        string[] spinnerTokens = { "|", "/", "-", "|", "-", "\\"};

        for (int i = 0; i < spinnerTokens.Length; i++)
        {
            Console.Write(spinnerTokens[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        
    }

    public void ShowCountDown()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }
}
