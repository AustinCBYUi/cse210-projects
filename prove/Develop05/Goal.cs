using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string desc, string points) 
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }


    public abstract void RecordEvent();


    public abstract bool IsComplete();


    public virtual string GetDetailsString()
    {
        return _points;
    }

    public virtual string GetTitle()
    {
        return _shortName;
    }


    public virtual string GetStringRepresentation()
    {
        string goalAsString = $"{_shortName} ({_description})";
        return goalAsString;
    }
}