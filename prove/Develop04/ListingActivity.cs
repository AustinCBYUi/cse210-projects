using System.ComponentModel;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();


    public ListingActivity(int userDuration) : base(userDuration)
    {
        _name = "Listing Activity";
        _description = "List as many things as you can in topics of strength or positivity!";
        _duration = userDuration;
    }


    public void Run()
    {
        //TODO
    }


    public void GetRandomPrompt()
    {
        //TODO
    }


    public List<string> GetListFromUser()
    {
        //Placeholder list
        List<string> todo = new List<string>();
        return todo;
    }
}