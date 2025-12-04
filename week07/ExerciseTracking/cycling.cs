using System;

public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        return (_speedKph * GetMinutes()) / 60;
    }

    public override double GetSpeed() => _speedKph;

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    protected override string GetActivityType()
    {
        return "🚴 Cycling";
    }
}
