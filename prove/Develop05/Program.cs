using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager mainGoalManager = new GoalManager();
        bool userQuitProgram = false;
        Console.ForegroundColor = ConsoleColor.Cyan;

        while (!userQuitProgram)
        {
            Console.WriteLine($"You have 0 points"); //Need to add points in here.
            mainGoalManager.GetMenu();
            string selectedChoice = Console.ReadLine();
            switch (selectedChoice)
            {
                case "1":
                    //Bulk of this gets the info needed and saves it as a Goal type named createNewGoal
                    Goal createNewGoal = mainGoalManager.Start();
                    //Which then gets added to the list?
                    mainGoalManager.CreateGoal(createNewGoal);
                    break;
                case "2":
                    mainGoalManager.ListGoalNames();
                    break;
            }
        }

    }
}