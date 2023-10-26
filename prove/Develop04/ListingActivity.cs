using System.ComponentModel;

/// <summary>
/// References the Listing Activity that inherits the Activity class as a base. Utilizes all
/// parent methods and attributes.
/// </summary>
public class ListingActivity : Activity
{
    private List<Entry> _userEntry = new List<Entry>();
    private int _count;
    private List<string> _prompts = new List<string>{
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    /// <summary>
    /// Constructor to set up the activity name and description from super's attributes.
    /// </summary>
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things your life by having you list as many things you can in certain areas!";
    }


    /// <summary>
    /// Runs the activity, also creates mainEntry to store the entries in a list.
    /// </summary>
    public void Run()
    {
        //mainEntry is just to store the entries in a list.
        Entry mainEntry = new Entry();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //Choose random prompt
        string prompt = GetRandomPrompt();
        Console.Write(prompt);
        //Seven seconds to think about it.
        ShowSpinner(7);
        //While the current time is less than the endtime
        while (DateTime.Now < endTime)
        {
            //Clear clutter
            Clear();
            Console.WriteLine(prompt);
            Console.Write(">>> ");
            string userInput = Console.ReadLine();
            //Create a new entry with parameters
            Entry newEntry = new Entry(prompt, userInput);
            //Add it to our mainEntry list.
            mainEntry.AddToEntryList(newEntry);
            //Add to count.
            _count += 1;
        }
        //Optionally save file.
        Console.Write("Save to file? (Y/N): ");
        string userTyped = Console.ReadLine();
        if (userTyped == "y" || userTyped == "yes")
        {
            mainEntry.WriteToFile("lis");
        }
    }


    /// <summary>
    /// Choose a random prompt by index and the Random class.
    /// </summary>
    /// <returns>The chosen prompt as a string.</returns>
    private string GetRandomPrompt()
    {
        Random newPrompt = new Random();
        int index = newPrompt.Next(_prompts.Count);
        string randomizedPrompt = _prompts[index];

        return randomizedPrompt;
    }
}