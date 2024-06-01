using System;
using System.Collections.Generic;
using System.IO;

// Base Goal class
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public int Points => _points; // Read-only property for points

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        // Base logic to record an event related to the goal
    }

    public virtual bool IsComplete()
    {
        // Base logic to check if the goal is complete
        return false;
    }

    public virtual string GetDetailsString()
    {
        // Base logic to get details string of the goal
        return $"{_shortName}: {_description}, Points: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        // Base logic to get string representation of the goal
        return $"{_shortName},{_description},{_points}";
    }

    
}