using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

/// <summary>
/// GoalManager references a manager that handles writing all goals, saving, loading, recording and a list of all created
/// goals.
/// </summary>
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _menu = @"
    Please select an option:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
    ";

    /// <summary>
    /// GoalManager constructor that handles writing all goals, saving, loading, recording, and Goals List.
    /// </summary>
    public GoalManager() {}


    /// <summary>
    /// Writes the formatted menu.
    /// </summary>
    public void GetMenu()
    {
        Console.WriteLine(_menu);
    }


    /// <summary>
    /// Creates a new menu and switch/case statements for user to choose what type of goal they'd like to create.
    /// </summary>
    /// <returns>a new Goal type named newGoal, whatever goal you wrote.</returns>
    public Goal Start()
    {
        Goal newGoal = null;
        Console.WriteLine(@"The Types of Goals are:
                    1. Simple Goal
                    2. Eternal Goal
                    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        string chosenGoal = Console.ReadLine();

        switch (chosenGoal)
        {
            //Create simple goal
            case "1":
                //For the others too: MainGoalQuestions has conditional statements to control the flow
                //of what questions are asked, I'm just using the string to specify this.
                newGoal = MainGoalQuestions("simple");
                break;
            //Create eternal goal
            case "2":
                newGoal = MainGoalQuestions("eternal");
                break;
            //Create checklist goal
            case "3":
                newGoal = MainGoalQuestions("checklist");
                break;
        }
        //Returns the newGoal!
        return newGoal;
    }


    /// <summary>
    /// Brilliant way to avoid typing this all out three separate times, wish I thought of doing this before I
    /// typed it out five total times instead.. Parameters must be "simple", "eternal", or "checklist" ONLY.
    /// </summary>
    /// <param name="goalType">This parameter MUST be set to simple, eternal, or checklist.</param>
    /// <returns>A new Goal object for the Start() function to run properly.</returns>
    private Goal MainGoalQuestions(string goalType)
        {
            /* 
            * Goal in programming is to reduce complexity, and to reduce the headache of writing repetitive code.
            * This is unfortunantely inevitable in this scenario, though I look wise writing a function for this,
            * it is mainly through actually writing it 4 times that I decided to make a function to handle this
            * algorithm! The nice thing is the three programs share the questions, and only checklist introduces
            * new ones! I'm proud to use this system however. Basically it checks the goalType by which type it
            * is, if it matches a condition it will either create that specific goal type through the constructor,
            * or it will ask a few more questions, THEN create the goal!
            */
            Goal newGoal = null;

            Console.Write("What is the name of your goal?: ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of your goal?: ");
            string goalDesc = Console.ReadLine();
            Console.Write("How would you value this goal in points?: ");
            string points = Console.ReadLine();
            if (goalType == "simple")
            {
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDesc, points);
                newGoal = newSimpleGoal;
            }
            else if (goalType == "eternal")
            {
                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDesc, points);
                newGoal = newEternalGoal;
            }
            else if (goalType == "checklist")
            {
                Console.Write("How many times does this goal need to be completed to recieve a bouns?: ");
                int clTarget = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for hitting your target?: ");
                int clBonus = int.Parse(Console.ReadLine());
                ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDesc, points, clTarget, clBonus);
                newGoal = newChecklistGoal;
            }
            return newGoal;
        }


    /// <summary>
    /// Displays players score.
    /// </summary>
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points!");
    }


    /// <summary>
    /// Lists the goals from the _goals list, uses a conditional to see if the goal is completed or not.
    /// If the goal is completed, an X Will be placed in the box, otherwise it will be left empty.
    /// </summary>
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() == true)
            {
                counter += 1;
                Console.WriteLine($"{counter}. [X] {goal.GetStringRepresentation()}");
            }
            else if (goal.IsComplete() == false)
            {
                counter += 1;
                Console.WriteLine($"{counter}. [ ] {goal.GetStringRepresentation()}");
            }
        }
    }


    /// <summary>
    /// Lists the goals to choose a selection to record a goal. Intended to be used for RecordEvent.
    /// </summary>
    /// <param name="manager">Must use the GoalManager type when called to transfer the instance.</param>
    /// <returns>An integer for the selection which is plugged in to the index minus 1.</returns>
    public int ListGoalDetails(GoalManager manager)
    {
        int selection = 0;
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter += 1;
            Console.WriteLine($"{counter}. {goal.GetTitle()}");
        }
        Console.Write("Choose a goal you completed!: ");
        selection = int.Parse(Console.ReadLine());

        return selection;
    }


    /// <summary>
    /// Creates a goal by adding the Goal newGoal to the _goals list.
    /// </summary>
    /// <param name="newGoal">Whichever goal that needs to be added to the list.</param>
    public void CreateGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }


    /// <summary>
    /// Records a finished goal by listing all goals with selection and short names, then taking the user selection
    /// and plugging it into the _goals list as an index, which subtracts 1 to match the index. Finally, uses the 
    /// specific inherited goals RecordEvent() method to either mark it as finished or add to _amountCompleted, and
    /// adds the points to _score.
    /// </summary>
    /// <param name="manager">Must use GoalManager type as a parameter.</param>
    public void RecordEvent(GoalManager manager)
    {
        //Get the user selection.
        int option = ListGoalDetails(manager);
        Goal newGoalOption = manager._goals[option - 1];
        newGoalOption.RecordEvent();
        string getPoints = newGoalOption.GetPoints();
        Console.WriteLine($"Congratulations! You earned {getPoints} points!");
        _score += int.Parse(getPoints); //Adds points
    }


    /// <summary>
    /// Saves all goals in the GoalManager list to a text file specifically formatted for unwrapping.
    /// </summary>
    public void SaveGoals()
    {
        Console.Write("What would you like to name the file (exclude extension)?: ");
        string fileName = Console.ReadLine();
        fileName = $"{fileName}.txt";
        try
        {
            using (StreamWriter output = new StreamWriter(fileName))
            {
                output.WriteLine($"{_score}"); //Might need to be changed?
                foreach (Goal goal in _goals)
                {
                    if (goal is not ChecklistGoal)
                    {
                        string getString = goal.GetDetailsString();
                        output.WriteLine($"{goal}|{getString}");
                    }
                    else if (goal is ChecklistGoal)
                    {
                        string getDetailsFromChecklist = goal.GetDetailsString();
                        output.WriteLine($"{goal}|{getDetailsFromChecklist}");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Successfully wrote to {fileName}!");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File unsuccessfully saved!");
            Console.WriteLine(e.Message);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }


    /// <summary>
    /// Loads user goals from a saved text file with the user input to locate the file name.
    /// </summary>
    /// <param name="manager">GoalManager type</param>
    public void LoadGoals(GoalManager manager)
    {
        Console.Write("What is the file you'd like to load(Exclude file extension)?: ");
        string loadFile = Console.ReadLine();
        loadFile = $"{loadFile}.txt";
        string[] lines = File.ReadAllLines(loadFile);
        //Gets score as ReadLines at First line.
        string getScore = File.ReadLines(loadFile).First();
        //Score is then set to the score you had.
        _score = int.Parse(getScore);
        
        //Loop through all lines.
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string goalType = parts[0];
            //If it's a SimpleGoal, it'll be written slightly different.
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                string completed = parts[4];
                //Boolean is for re-adding finished goals.
                bool isComplete = false;
                if (completed == "true")
                {
                    isComplete = true;
                }
                else
                {
                    isComplete = false;
                }
                SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points, isComplete);
                manager.CreateGoal(newSimpleGoal);
            }
            //EternalGoals don't have booleans.
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                EternalGoal newEternalGoal = new EternalGoal(name, description, points);
                manager.CreateGoal(newEternalGoal);
            }
            //Checklist goals are written extremely different.
            if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);
                ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus, completed);
                manager.CreateGoal(newChecklistGoal);
            }
        }
    }
}