using System.Runtime.InteropServices;
/// <summary>
/// References the Breathing Activity that inherits the Activity class as a base. Utilizes all
/// parent methods and attributes.
/// </summary>
public class BreathingActivity : Activity
{
    private int _breathingDuration;
    /// <summary>
    /// Constructor to set up the activity's name and description.
    /// </summary>
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "Practice controlled breathing for mindfulness.";
    }


    /// <summary>
    /// Runs the activity, uses DateTime.
    /// </summary>
    public void Run()
    {
        DisplayStartingMessage(); //Gets _duration too I hope?
        //I love that I can call a method with a variable and not have to call the method
        //separately to display the Console stuff. Makes things easier and it's one line for what would take at least 2!
        int getTime = BreathingTimes();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //clear clutter
        Clear();
        
        //while countdown is running.
        while (DateTime.Now < endTime)
        {
            //Start the countdown from the user input duration.
            Console.WriteLine("-------- Inhale --------");
            ShowCountDown(getTime);
            //Exhale
            Console.WriteLine("-------- Exhale --------");
            ShowCountDown(getTime);
        }
        DisplayEndingMessage();
    }


    /// <summary>
    /// User specified breathing durations between 4 secodns and 8 seconds.
    /// </summary>
    /// <returns>_breathingDuration as a int for seconds.</returns>
    private int BreathingTimes()
    {
        Console.WriteLine("Please choose a breathing interval.");
        Console.WriteLine("1) Short is 4 seconds | 2) normal is 6 seconds | 3) long intervals is 8 seconds for breathing?");
        Console.Write("<> ");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 1)
        {
            _breathingDuration = 4;
        }
        else if (userInput == 2)
        {
            _breathingDuration = 6;
        }
        else if (userInput == 3)
        {
            _breathingDuration = 8;
        }
        else
        {
            _breathingDuration = 6;
        }
        return _breathingDuration;
    }
}