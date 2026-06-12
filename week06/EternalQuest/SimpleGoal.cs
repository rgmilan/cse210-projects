public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordsEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
        return $"{GetStatus()} {GoalName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GoalName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}