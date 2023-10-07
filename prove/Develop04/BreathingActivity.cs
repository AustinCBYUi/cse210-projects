using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
//Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find
//more peace and less stress through the exercise.
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "Practice controlled breathing for mindfulness.";
    }



    public void Run()
    {
        DisplayStartingMessage(); //Gets _duration too I hope?
        Console.WriteLine("Get ready...");
        ShowSpinner(5); //set to 5 instead.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        //while countdown is running
        while (DateTime.Now < endTime)
        {
            //Start the countdown from the user input duration.
            //Show message with a countdown with "Inhale" in the format string
            Console.WriteLine("-------- Inhale --------");
            ShowCountDown();
            //Exhale
            Console.WriteLine("-------- Exhale --------");
            ShowCountDown();
        }
        DisplayEndingMessage();
    }
}