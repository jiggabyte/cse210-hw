using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by guiding you through deep breathing exercises."
        ) { }

    public void Run()
    {
        DateTime startTime = DateTime.Now;        

        DisplayStartingMessage();
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Get Ready!");
        ShowSpinner();
        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            for (int i = 0; i < _duration; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Breathe in ... ");
                    ShowCountDown();
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Breathe out ... ");
                    ShowCountDown();
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine("Well Done.");
        ShowSpinner();
        DisplayEndingMessage();
    }
}
