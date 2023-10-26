/// <summary>
/// References a parent class that defines the behavior for the children classes.
/// Contains starter attributes and methods to create the outline for children classes.
/// </summary>
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    /// <summary>
    /// Displays a starting message with modularity for each child class. Optional parameter.
    /// </summary>
    /// <param name="type">Optional parameter that is used to specify which child
    /// class is calling this method.</param>
    public void DisplayStartingMessage(string type = "")
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"{_description}\n");

        //If ref is the parameter it'll display a deviated message.
        if (type == "ref")
        {
            Console.WriteLine("For the Reflecting activity, you must choose between 60-120 seconds.");
            Console.Write("How long would you like your timer to be?: ");
            _duration = int.Parse(Console.ReadLine());
            if (_duration <= 59)
            {
                Console.WriteLine("You'll need longer than that.. Try again.");
                DisplayStartingMessage("ref");
            }
            else if (_duration >= 121)
            {
                Console.WriteLine("That may be a little too long.. Try lower.");
                DisplayStartingMessage("ref");
            }
        }
        //If lis is the parameter, it'll display a deviated message as well.
        else if (type == "lis")
        {
            Console.WriteLine("For the Listing Activity, you must choose between 30-90 seconds.");
            Console.Write("How long would you like your timer to be?: ");
            _duration = int.Parse(Console.ReadLine());
            if (_duration < 30)
            {
                Console.WriteLine("You'll need longer than that.. Try again.");
                DisplayStartingMessage("lis");
            }
            else if (_duration > 90)
            {
                Console.WriteLine("That may be a little too long.. Ty lower.");
                DisplayStartingMessage("lis");
            }
        }
        //Catching all proper conditions.
        else
        {
        Console.Write("How long would you like your timer to be in seconds?: ");
        _duration = int.Parse(Console.ReadLine());
        }
    }


    /// <summary>
    /// Display a ending message with modularity for each child class. Takes an optional parameter.
    /// </summary>
    /// <param name="optionalCount">Optional count is an optional parameter that displays
    /// the counted entries from Reflecting and Listing activities.</param>
    public void DisplayEndingMessage(int optionalCount = 0)
    {
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed a {_name} for {_duration} seconds!\n");
        if (optionalCount > 1)
        {
            Console.WriteLine($"You completed {optionalCount} entries!");
        }
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

            //Increment
            i ++;

            //If i is greater than or equal to the count of list (8), reset i to 0 to
            //restart the images to keep the spinner spinning.
            if (i >= animatedStrings.Count)
            {
                i = 0;
            }

        }
    }


/// <summary>
/// Displays a countdown. Numbers are replaced overtop themselves.
/// </summary>
/// <param name="seconds">Optional seconds for max countdown, default at 6.</param>
    protected void ShowCountDown(int optionalSeconds = 6)
    {
        //for integer i = this is the max seconds; i greater than 0; i is decrementing. (counting down)
        //i needs to be greater than 0 to keep running.
        //So start, target, loop specification.
        for (int i = optionalSeconds; i > 0; i --)
        {
            //Inhale for 10 seconds, 10-9-8... as an example
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


    /// <summary>
    /// Function to clear the console using only Clear() instead of Console.Clear().
    /// </summary>
    public void Clear()
    {
        Console.Clear();
    }

}