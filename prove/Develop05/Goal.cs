using System.ComponentModel;
/// <summary>
/// Parent class that controls every goal created.
/// </summary>
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    /// <summary>
    /// Basic constructor for the other goals to use for similar data.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="desc">Goal description</param>
    /// <param name="points">Goal points</param>
    public Goal(string name, string desc, string points) 
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }


    /// <summary>
    /// For recording events, only really used for SimpleGoal.
    /// </summary>
    public abstract void RecordEvent();


    /// <summary>
    /// For checking if a goal has been completed.
    /// </summary>
    /// <returns>True/False</returns>
    public abstract bool IsComplete();


    /// <summary>
    /// Deprecated, is no longer used despite the 5 references.
    /// </summary>
    /// <returns>Points of an assigned goal.</returns>
    public virtual string GetDetailsString()
    {
        return _points;
    }


    /// <summary>
    /// Created to display shortName / goal titles only.
    /// </summary>
    /// <returns>The name of the user created goal.</returns>
    public virtual string GetTitle()
    {
        return _shortName;
    }


    /// <summary>
    /// Gets points of the goal.
    /// </summary>
    /// <returns>How many points a goal is worth.</returns>
    public virtual string GetPoints()
    {
        return _points;
    }


    /// <summary>
    /// Basic guideline of how the goals should be displayed, though it is overriden every time.
    /// </summary>
    /// <returns>A string that represents the formatted goal.</returns>
    public virtual string GetStringRepresentation()
    {
        string goalAsString = $"{_shortName} ({_description})";
        return goalAsString;
    }
}