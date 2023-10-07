public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(int userDuration)
    {
        _duration = userDuration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine($"{_description}");

    }


    public void CreateCountdown(int seconds)
    {

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