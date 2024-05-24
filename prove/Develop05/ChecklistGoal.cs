using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public new void RecordEvent()
    {
        // Logic to record an event related to the checklist goal
    }

    public new bool IsComplete()
    {
        // Logic to check if the checklist goal is complete
        return _amountCompleted >= _target;
    }

    public new string GetDetailsString()
    {
        // Logic to get details string of the checklist goal
        return "";
    }

    public new string GetStringRepresentation()
    {
        // Logic to get string representation of the checklist goal
        return base.GetStringRepresentation();
    }
}