public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _description = desc;
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        string welcomeMsg = "Welcome to the Mindfulness Program!";
        Console.WriteLine(welcomeMsg);
    }


    public void DisplayEndingMessage()
    {
        //TODO
    }


    public void ShowSpinner(int seconds)
    {
        //TODO
    }


    public void ShowCountDown(int seconds)
    {
        //TODO
    }
}