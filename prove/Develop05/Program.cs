using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Initialize a new Goal Manager that will control mostly everything.
        GoalManager mainGoalManager = new GoalManager();
        //Set up a boolean for if the user quits.
        bool userQuitProgram = false;
        //Change the color of text to Cyan
        Console.ForegroundColor = ConsoleColor.Cyan;

        while (!userQuitProgram)
        {
            //Displays points
            mainGoalManager.DisplayPlayerInfo();
            //Displays the menu in GoalManager
            mainGoalManager.GetMenu();
            //Read user input
            string selectedChoice = Console.ReadLine();
            //Start switch off of user input
            switch (selectedChoice)
            {
                //Create New Goal
                case "1":
                    //Bulk of this gets the info needed and saves it as a Goal type named createNewGoal
                    //which then gets sent to the GoalManager's CreateGoal() method.
                    Goal createNewGoal = mainGoalManager.Start();
                    //Which then gets added to the list?
                    mainGoalManager.CreateGoal(createNewGoal);
                    break;
                //List Goals
                case "2":
                    mainGoalManager.ListGoalNames();
                    break;
                //Save Goals
                case "3":
                    mainGoalManager.SaveGoals();
                    break;
                //Load Goals
                case "4":
                    mainGoalManager.LoadGoals(mainGoalManager);
                    break;
                //Record Event
                case "5":
                    //Uses goalmanager's Record Event with the manager as a param.
                    mainGoalManager.RecordEvent(mainGoalManager);
                    break;
                //Quit
                case "6":
                    userQuitProgram = true;
                    Environment.Exit(0);
                    break;
            }
        }

    }
}