using System.Runtime.InteropServices;
/// <summary>
/// References the Breathing Activity that inherits the Activity class as a base. Utilizes all
/// parent methods and attributes.
/// </summary>
public class BreathingActivity : Activity
{
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
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        //while countdown is running.
        while (DateTime.Now < endTime)
        {
            //Start the countdown from the user input duration.
            Console.WriteLine("-------- Inhale --------");
            ShowCountDown();
            //Exhale
            Console.WriteLine("-------- Exhale --------");
            ShowCountDown();
        }
        DisplayEndingMessage();
    }
}