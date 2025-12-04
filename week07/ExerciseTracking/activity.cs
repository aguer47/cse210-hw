using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    
    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    
    protected virtual string GetActivityType()
    {
        return "Activity";
    }

    // Summary method 
    public string GetSummary()
    {
        return $"{GetDate()} {GetActivityType()} ({GetMinutes()} min)\n"
             + $"  Distance: {GetDistance():0.00} km\n"
             + $"  Speed: {GetSpeed():0.00} kph\n"
             + $"  Pace: {GetPace():0.00} min/km\n";
    }
}
