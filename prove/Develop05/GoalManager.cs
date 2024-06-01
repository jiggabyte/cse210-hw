using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Logic to start the goal manager
        Console.WriteLine("Goal Manager started.");
    }

    public void DisplayPlayerInfo()
    {
        // Logic to display player information
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        // Logic to list goal names
        Console.WriteLine("Goals:");
        foreach (var goal in _goals.Select((value, i) => ( value, i )))
        {
            string status = goal.value.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{goal.i}. {status} {goal.value.GetStringRepresentation()}");
        }
    }

    public void ListGoalDetails()
    {
        // Logic to list goal details
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        // Logic to create a new goal
        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");

        int choice;
        
        // Added try / catch block for graceful error handling.
        try
        {
            choice = int.Parse(Console.ReadLine());
        }
        catch(Exception exception)
        {
            Console.WriteLine("Program Exiting: Reason Invalid input. Please retry!");
            Environment.Exit(0);
            choice = 0;
        }

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter goal points:");

        int points;
        
        // Added try / catch block for graceful error handling.
        try
        {
            points = int.Parse(Console.ReadLine());
        }
        catch(Exception exception)
        {
            Console.WriteLine("Program Exiting: Reason Invalid input. Please retry!");
            Environment.Exit(0);
            points = 0;
        }


        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.WriteLine("Enter target times:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;

        }

        Console.WriteLine("New goal created.");
    }

    public void RecordEvent()
    {
        // Logic to record an event
        ListGoalNames();
        Console.WriteLine("Select goal number to record event:");

        int index;
        
        // Added try / catch block for graceful error handling.
        try
        {
            index = int.Parse(Console.ReadLine());
        }
        catch(Exception exception)
        {
            Console.WriteLine("Program Exiting: Reason Invalid input. Please retry!");
            Environment.Exit(0);
            index = 0;
        }

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].Points;

            if (_goals[index] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
            }

            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        // Logic to save goals
        Console.Write("Enter the name of a file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        // Logic to load goals
        Console.Write("Enter the name of a file: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            if (bool.Parse(parts[4]))
                            {
                                simpleGoal.RecordEvent();
                            }
                            _goals.Add(simpleGoal);
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;

                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            for (int i = 0; i < int.Parse(parts[4]); i++)
                            {
                                checklistGoal.RecordEvent();
                            }
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals to load.");
        }
    }
}
