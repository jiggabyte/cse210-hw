using System;
using System.Collections.Generic;
using System.IO;


public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // Additional constructor logic if needed
    }

    public override void RecordEvent()
    {
        // Implement logic to record an event related to the eternal goal
        // Example: Increment an internal counter or log the event
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Implement logic to get string representation of the eternal goal
        return $"EternalGoal,{base.GetStringRepresentation()}";
    }
}
