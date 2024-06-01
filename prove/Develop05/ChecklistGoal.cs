using System;
using System.Collections.Generic;
using System.IO;


public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int AmountCompleted => _amountCompleted;
    public int Target => _target;
    public int Bonus => _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        // Implement logic to record an event related to the checklist goal
        // Example: Increment the completed amount
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        // Implement logic to check if the checklist goal is complete
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        // Implement logic to get details string of the checklist goal
        return $"{base.GetDetailsString()}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        // Implement logic to get string representation of the checklist goal
        return $"ChecklistGoal,{base.GetStringRepresentation()},{_amountCompleted},{_target},{_bonus} --- Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }


}