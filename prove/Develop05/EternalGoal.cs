/// <summary>
/// Goal type that will never be completed.
/// </summary>
public class EternalGoal : Goal
{
    /// <summary>
    /// Basic constructor to create a new goal.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="description">Goal description</param>
    /// <param name="points">Goal's points</param>
    public EternalGoal(string name, string description, string points) : base(name, description, points) {}

    
    /// <summary>
    /// Not used at all, though it is referenced. Due to the super being an abstract, this will stay here.
    /// </summary>
    public override void RecordEvent() {}


    /// <summary>
    /// Always returns false as a Eternal Goal cannot be completed.
    /// </summary>
    /// <returns>FALSE</returns>
    public override bool IsComplete()
    {
        return false;
    }


    /// <summary>
    /// Formats the Eternal goal to be stored in the .txt file
    /// </summary>
    /// <returns>String designed to be used only in the .txt.</returns>
    public override string GetDetailsString()
    {
        string eternalString = $"{_shortName}|{_description}|{_points}";
        return eternalString;
    }
}