//same thing as math assignment, left is new class / child, one on right is base / parent / main class that
// we are inheriting from.
public class WritingAssignment : Assignment
{
    //New attribute we are creating that is exclusive for this class.
    private string _title;


    //Constructor is using the parent class constructor too, which uses studentName and topic.
    //That constructor is THEN called with : base(studentName, topic) which would be parameters.
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }


    //Just formats the private attribute to display to console.
    public string GetWritingInformation()
    {
        string summary = $"Writing Assignment\nTitle: {_title}";

        return summary;
    }
}