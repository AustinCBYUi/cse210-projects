public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

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
        string eternalString = $"{_shortName}|{_description}|{_points}";
        return eternalString;
    }


    // public override string GetStringRepresentation()
    // {
    //     return "This is Eternal Goals";
    // }
}