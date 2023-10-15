/// <summary>
/// ChecklistGoal is a specific type of goal that requires x amount of times to be completed before checking it off.
/// </summary>
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    /// <summary>
    /// Basic constructor for a ChecklistGoal. This one should always be used over.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="desc">Goal Description</param>
    /// <param name="points">Goal's points</param>
    /// <param name="targ">Goals target to hit</param>
    /// <param name="bonus">Goal's bonus points for reaching target.</param>
    public ChecklistGoal(string name, string desc, string points, int targ, int bonus) : base(name, desc, points)
    {
        _target = targ;
        _bonus = bonus;
    }

    /// <summary>
    /// Constructor is used specifically for fetching data from .txt file
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="desc">Goal description</param>
    /// <param name="points">Goal points</param>
    /// <param name="targ">Goal target</param>
    /// <param name="bonus">Goal's bonus</param>
    /// <param name="completed">Amount of goal completed.</param>
    public ChecklistGoal(string name, string desc, string points, int targ, int bonus, int completed) : base(name, desc, points)
    {
        _target = targ;
        _bonus = bonus;
        _amountCompleted = completed;
    }


    /// <summary>
    /// Records if an event has been completed. If the amount completed thus far is less than the target
    /// it will add one, if the amount completed is equal to the target, it will set the IsComplete() to true.
    /// </summary>
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
        }
        else if (_amountCompleted == _target)
        {
            _amountCompleted = _target;
            IsComplete();
        }
    }

    /// <summary>
    /// Checks if the Checklist Goal has been completed by checking if the amount completed has hit the target.
    /// </summary>
    /// <returns></returns>
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else if (_amountCompleted != _target)
        {
            return false;
        }
        return false;
    }


    /// <summary>
    /// Gets the checklist goal and formats it for the .txt file.
    /// </summary>
    /// <returns>String that is specified for .txt file usage.</returns>
    public override string GetDetailsString()
    {
        string getDetails = $"{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
        return getDetails;
    }


    /// <summary>
    /// Formatted version of checklist goal for front-end.
    /// </summary>
    /// <returns>String that is formatted for the user to see.</returns>
    public override string GetStringRepresentation()
    {
        string getDetails = $"{_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        return getDetails;
    }
}