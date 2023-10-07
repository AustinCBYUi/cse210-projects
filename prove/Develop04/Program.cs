using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Activity super = new Activity(0);
        int userDuration = 0;
        //BreathingActivity bActivity = new BreathingActivity(bName, bDesc, duration);


        bool userQuit = false;

        while (userQuit == false)
        {
            super.Clear();
            Console.WriteLine(@"""
Welcome to the Mindfulness Program!
Please type the number for the activity you choose!

1) Breathing Activity
2) Reflecting Activity
3) Listing Activity
4) Exit Application"""
);
            //Carrot
            Console.Write(">>> ");
            //Int conversion from console.
            int typed = int.Parse(Console.ReadLine());

            switch (typed)
            {
                case 1:
                    super.Clear();
                    BreathingActivity startActivity = new BreathingActivity();
                    startActivity.Run();
                    break;
                case 2:
                    super.Clear();
                    ReflectingActivity startRefActivity = new ReflectingActivity();
                    startRefActivity.Run();
                    break;
                case 3:
                    break;
                case 4:
                    System.Console.Beep();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}