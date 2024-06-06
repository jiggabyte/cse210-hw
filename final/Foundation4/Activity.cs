using System;
using System.Collections.Generic;

abstract class Activity
{
    protected string _date;
    protected int _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityType();

    protected Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        return $"{_date} {GetActivityType()} ({_length} min): Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}

