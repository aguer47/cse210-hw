public class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string desc, int penalty)
        : base(name, desc, penalty) { }

    public override int RecordEvent()
    {
        return -GetPoints(); // Deduct points.
    }

    public override string GetStatus()
    {
        return "[! BAD HABIT !]";
    }
}
