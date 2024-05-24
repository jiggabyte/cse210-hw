using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public new void RecordEvent()
    {
        // Logic to record an event related to the simple goal
    }

    public new bool IsComplete()
    {
        // Logic to check if the simple goal is complete
        return _isComplete;
    }

    public new string GetStringRepresentation()
    {
        // Logic to get string representation of the simple goal
        return base.GetStringRepresentation();
    }
}
