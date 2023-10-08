/// <summary>
/// References the Reflecting Activity that inerits the Activity Class as a base. Utilizes
/// all the parent attributes and methods.
/// </summary>
public class ReflectingActivity : Activity
{
    private int _recordEachEntry;
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else..",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need"
    };
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful for you?",
        "Have you ever done something like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?"
    };



    /// <summary>
    /// Constructor for setting the name and description of the activity using super's attributes.
    /// </summary>
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life you've shown strength and resilience.";
    }


    /// <summary>
    /// Run the activity, uses datetime to time the user, optionally send your entries to a text file through
    /// the Entry.cs.
    /// </summary>
    public void Run()
    {
        string thePrompt = GetRandomPrompt();
        DisplayStartingMessage("ref");
        ShowSpinner();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //Creates an instance of Entry to save to the Entry list
        //this helps when we want to save the entries.
        Entry mainEntry = new Entry();

        //While the current time is less than the end time!
        while (DateTime.Now < endTime)
        {
            //Write the prompt
            Console.WriteLine($"-- {thePrompt} --\n");
            ShowSpinner(5);
            string newQuestion = GetRandomQuestion();
            //Write the question
            Console.WriteLine(newQuestion);
            ShowSpinner(5);
            Console.Write(">>> ");
            string userInput = Console.ReadLine();
            //Creates a new entry.
            Entry newEntry = new Entry(thePrompt, newQuestion, userInput);
            //Record the entry.
            _recordEachEntry += 1;
            //Add to the mainEntry list.
            mainEntry._entry.Add(newEntry);
        }
        //Optional ability to save your entries to a file.
        Console.Write("Save to file? (Y/N): ");
        string userTyped = Console.ReadLine().ToLower();
        //I try to catch both conditions I guess?
        if (userTyped == "y" || userTyped == "yes")
        {
            //ref is a parameter specifying which template to use.
            mainEntry.WriteToFile("ref");
        }

        //Another optional parameter, in this case I want the console to tell the user
        //how many entries were written.
        DisplayEndingMessage(_recordEachEntry);
    }


    /// <summary>
    /// Chooses a random prompt from the _prompts list by a random index number.
    /// </summary>
    /// <returns>The selected prompt as a string.</returns>
    private string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int index = randomNumber.Next(_prompts.Count);
        
        string randomSelection = _prompts[index];

        return randomSelection;
    }


    /// <summary>
    /// Chooses a random question from the _questions list by a random index number.
    /// </summary>
    /// <returns>The selected question as a string.</returns>
    private string GetRandomQuestion()
    {
        Random randomNumber = new Random();
        int index = randomNumber.Next(_questions.Count);

        string randomSelection = _questions[index];

        return randomSelection;
    }

    
    private void DisplayPrompt()
    {
        string newPrompt = GetRandomPrompt();
        Console.WriteLine(newPrompt);
    }


    private void DisplayQuestions()
    {
        string newQuestion = GetRandomQuestion();
        Console.WriteLine(newQuestion);
    }
}