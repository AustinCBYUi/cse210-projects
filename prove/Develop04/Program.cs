using System;

class Program
{
    static void Main(string[] args)
    {
        //Constructors
        string bName = "Breathing Activity";
        string bDesc = "Practice controlled breathing for mindfulness";
        int userDuration = 0 * 1000;
        //BreathingActivity bActivity = new BreathingActivity(bName, bDesc, duration);


        bool userQuit = false;

        while (userQuit == false)
        {

            Console.WriteLine(@"""
            Welcome to the Mindfulness Program!
            Please type the number for the activity you choose!

            1) Breathing Activity
            2) Reflecting Activity
            3) Listing Activity\n""");
            //Carrot
            Console.Write(">>>");
            //Int conversion from console.
            int typed = int.Parse(Console.ReadLine());

            switch (typed)
            {
                case 1:
                    Console.Write("How long in seconds would you like for your session?: ");
                    userDuration = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}