public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetStatus()
    {
        return "[∞]";  // never complete
    }
}
