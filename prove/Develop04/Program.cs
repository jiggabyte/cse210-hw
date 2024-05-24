using System;

/* 
Submission Comment: I added a try catch block to handle incorrect _duration input
*/

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("Exiting the Mindfulness App. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}