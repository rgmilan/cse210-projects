public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoint;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int bonusPoints
    ) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoint = bonusPoints;
        _currentCount = 0;
    }

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int bonusPoints,
        int currentCount
    ) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoint = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordsEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;

            if (_currentCount == _targetCount)
            {
                return GetPoints() + _bonusPoint;
            }

            return GetPoints();
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetails()
    {
        return $"{GetStatus()} {GoalName()} ({GetDescription()}) -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GoalName()},{GetDescription()},{GetPoints()},{_targetCount},{_bonusPoint},{_currentCount}";
    }
}