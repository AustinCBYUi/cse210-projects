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
        return base.GetDetailsString();
    }


    public override string GetStringRepresentation()
    {
        string getDetails = $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        return getDetails;
    }
}