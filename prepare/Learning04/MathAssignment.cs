//How to use inheritance.
//Left is child obviously, : this side is parent / base.
public class MathAssignment : Assignment
{
    //New private attributes exclusive to this child.
    private string _textbookSection;
    private string _problems;


    //In this scenario, we're using a constructor to just set all of the values we want,
    //But in this case, we still plug in the parent classes info too which is studentName and topic.
    //That is basically recieved from the : base() at the end there which calls the base constructor too!
    public MathAssignment(string studentName, string topic, string texSection, string problems) : base(studentName, topic)
    {
        _textbookSection = texSection;
        _problems = problems;
    }


    //Just displays homework problems from the encapsulated attributes above!
    public string GetHomeWorkProblems()
    {
        string problems = $"Math Assignment\nSection {_textbookSection} Problems {_problems}.";

        return problems;
    }
}