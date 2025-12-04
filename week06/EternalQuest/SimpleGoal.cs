public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        if (_isComplete)
            return 0;

        _isComplete = true;
        return GetPoints();
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public bool IsComplete() => _isComplete;
}
