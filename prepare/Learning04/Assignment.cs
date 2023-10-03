//Primary base class,
public class Assignment
{
    //Private attributes that can be inherited and modified.
    private string _studentName;
    private string _topic;


    //Not using summary to explain this:
    //Constructor which just constructs from this class, but using inheritance
    //as we will see, we can just use THIS constructor to modify our attributes here
    //to then display out studentname and topic.
    public Assignment(string studentName, string topic)
    {
        string formattedName = ReFormatName(studentName);

        _studentName = formattedName;
        _topic = topic;

    }


    //Get summarysimply just formats student name - topic, and returns it as a string.
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}\n";

        return summary;
    }


    //I did this to be cool, always like private methods. This method would be exclusive to the Assignment class,
    //I don't believe it is inheritable. Either way it just splits the studentName and returns last Name and first name
    //in that order.
    private string ReFormatName(string studentName)
    {
        string[] names = studentName.Split(" ");
        string firstName = names[0];
        string lastName = names[1];
        
        return lastName + " " + firstName;
    }
}