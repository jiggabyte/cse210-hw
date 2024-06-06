using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        // Create activities of each type
        Cycling cyclingActivity = new Cycling("2024-06-06", 60, 20); // Date, Length (minutes), Speed (kph)
        Running runningActivity = new Running("2024-06-06", 30, 5);   // Date, Length (minutes), Distance (kilometers)
        Swimming swimmingActivity = new Swimming("2024-06-06", 45, 10); // Date, Length (minutes), Laps

        // Add activities to the list
        List<Activity> activities = new List<Activity>();
        activities.Add(cyclingActivity);
        activities.Add(runningActivity);
        activities.Add(swimmingActivity);

        // Iterate through the list and display the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}