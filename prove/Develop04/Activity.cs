public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected bool _activityDone = false;

    public Activity(int userDuration)
    {
        //userDuration is the total duration of said activity.
        _duration = userDuration;
    }

    public Activity() {}


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine($"{_description}");

        Console.Write("How long would you like to preform this exercise?: ");
        _duration = int.Parse(Console.ReadLine());

    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.Write($"You have completed a {_name} for {_duration} seconds!\n");
        ShowSpinner(4);
    }


/// <summary>
/// Displays a loading spinner for a default of ten seconds unless specified otherwise.
/// Displays each character in the spinner per 100ms.
/// </summary>
/// <param name="optionalSeconds">Seconds as integer which is optional, do not exceed 12sec.</param>
    public void ShowSpinner(int optionalSeconds = 10) //Had int Seconds in it for parameter?
    {
        if (optionalSeconds > 12)
        {
            optionalSeconds = 10;
        }
        List<string> animatedStrings = new List<string>{
            "|", "/", "-", "\\", "|", "/", "-", "\\"
            };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(optionalSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string animations = animatedStrings[i];
            Console.Write(animations);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i ++;

            if (i >= animatedStrings.Count)
            {
                i = 0;
            }

        }
    }


/// <summary>
/// Displays a countdown with a formatted string with activity type (like inhale/exhale for x seconds).
/// </summary>
/// <param name="seconds">Optional seconds for max countdown, default at 5.</param>
    protected void ShowCountDown(int optionalSeconds = 6)
    {
        for (int i = optionalSeconds; i > 0; i --)
        {
            //Inhale for 10 seconds, 10-9-8... as an example
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


    public void Clear()
    {
        Console.Clear();
    }
}