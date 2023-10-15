/// <summary>
/// Simple goal that inherits from the Goal class, creates a simple goal that can be marked completed.
/// </summary>
public class SimpleGoal : Goal
{
    private bool _isComplete;

    /// <summary>
    /// Normal usage constructor. Only this one should be used for creating goals.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="description">Goal description</param>
    /// <param name="points">Goal's points</param>
    public SimpleGoal(string name, string description, string points) : base(name, description, points) {}

    /// <summary>
    /// This constructor is only used for re-creating goals from the saved goals .txt file.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="desc">Goal description</param>
    /// <param name="points">Goal points</param>
    /// <param name="completed">If goal has been completed or not.</param>
    public SimpleGoal(string name, string desc, string points, bool completed) : base(name, desc, points) 
    {
        _isComplete = completed;
    }


    /// <summary>
    /// When this method is called for this goal, it will just set it to completed.
    /// </summary>
    public override void RecordEvent()
    {
        _isComplete = true;
    }


    /// <summary>
    /// RETURNS the _isComplete boolean, if it's been completed it'll be true, if not false.
    /// </summary>
    /// <returns>True or false based if the goal has been completed.</returns>
    public override bool IsComplete()
    {
        return _isComplete;
    }


    /// <summary>
    /// Formats the goal specifically for the .txt file to save contents.
    /// </summary>
    /// <returns>String that is only good for the .txt file.</returns>
    public override string GetDetailsString()
    {
        string simpleGoalString = $"{_shortName}|{_description}|{_points}|{_isComplete}";
        return simpleGoalString;
    }
}