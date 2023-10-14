using System.Runtime.CompilerServices;

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

    public GoalManager() {}


    public void GetMenu()
    {
        Console.WriteLine(_menu);
    }


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
            * new ones! I'm proud to use this system however.
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


    public void DisplayPlayerInfo()
    {

    }


    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter += 1;
            Console.WriteLine($"{counter}. {goal.GetStringRepresentation()}");
        }
    }


    public void ListGoalDetails()
    {

    }


    public void CreateGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }


    public void RecordEvent(Goal newGoal)
    {
        _goals.Add(newGoal);

        Console.WriteLine(_goals);
    }


    public void SaveGoals()
    {

    }


    public void LoadGoals()
    {

    }
}