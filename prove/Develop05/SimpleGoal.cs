using System;
using System.Collections.Generic;
using System.IO;


public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // Logic to record an event related to the simple goal
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        // Logic to check if the simple goal is complete
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Logic to get string representation of the simple goal
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isComplete}";
    }
}