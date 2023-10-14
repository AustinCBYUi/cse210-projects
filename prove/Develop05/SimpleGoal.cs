public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points) {}

    public SimpleGoal(string name, string desc, string points, bool completed) : base(name, desc, points) 
    {
        _isComplete = completed;
    }


    public override void RecordEvent()
    {
        
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetDetailsString()
    {
        string simpleGoalString = $"{_shortName}|{_description}|{_points}|{_isComplete}";
        return simpleGoalString;
    }


    // public override string GetStringRepresentation()
    // {
    //     string goalAsString = $"[ ] {_shortName} ({_description})";
    //     return goalAsString;
    // }
}