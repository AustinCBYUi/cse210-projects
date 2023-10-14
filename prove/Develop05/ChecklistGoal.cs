public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, string points, int targ, int bonus) : base(name, desc, points)
    {
        _target = targ;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string desc, string points, int targ, int bonus, int completed) : base(name, desc, points)
    {
        _target = targ;
        _bonus = bonus;
        _amountCompleted = completed;
    }


    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }


    public override bool IsComplete()
    {
        return false;
    }


    public override string GetDetailsString()
    {
        string getDetails = $"{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
        return getDetails;
    }


    public override string GetStringRepresentation()
    {
        string getDetails = $"{_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        return getDetails;
    }
}