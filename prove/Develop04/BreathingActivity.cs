public class BreathingActivity : Activity
{
    private bool _activityDone = false;
//Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find
//more peace and less stress through the exercise.
    public BreathingActivity(int userDuration) : base(userDuration)
    {
        _name = "Breathing Activity";
        _description = "Practice controlled breathing for mindfulness.";
        _duration = userDuration;
    }



    public void Run()
    {
        while (_activityDone == false)
        {
            Console.WriteLine("Get ready...");
            //display animations here for 3 seconds?

            
        }
    }
}