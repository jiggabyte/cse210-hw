using System;


// This program exceeds the base requirements by implementing the following features:
// 1. Added error handling to the goal manager class handling non numeric inputs
// 2. added an extra menu to display goal details




class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");            
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");

            int choice;

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch(Exception exception)
            {
                choice = 0;
            }
            

            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();                    
                    break;
                case 2:
                    goalManager.ListGoalNames();
                    break;
                case 3:
                    goalManager.ListGoalDetails();
                    break;
                case 4:
                    goalManager.DisplayPlayerInfo();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    goalManager.SaveGoals();
                    break;
                case 7:
                    goalManager.LoadGoals();
                    break;
                case 8:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
