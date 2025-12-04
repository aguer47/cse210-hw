public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        if (_count >= _target)
            return 0;

        _count++;

        if (_count == _target)
            return GetPoints() + _bonus;

        return GetPoints();
    }

    public override string GetStatus()
    {
        return $"[{_count}/{_target}]";
    }

    public bool IsComplete() => _count >= _target;
}
