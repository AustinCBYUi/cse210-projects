/// <summary>
/// Created by two types of entry instances. A main entry which is designed to keep track of the Entries list,
/// and the Writing to file. Creating individual entries through the loops is the proper way to create the single
/// entries. The main entry must add to the Entry list via AddToEntry method with the individual entry as a parameter.
/// </summary>
public class Entry : Activity
{
    private List<Entry> _entry = new List<Entry>();
    private string _prompt;
    private string _question;
    private string _userText;


    /// <summary>
    /// Single constructor for initializing mainEntries instead of individual entries.
    /// </summary>
    public Entry() {}


    //Constructor for ReflectingActivity.cs
    /// <summary>
    /// Constructor designed specifically for Reflecting Activity entries.
    /// </summary>
    /// <param name="prompt">Prompt picked by program.</param>
    /// <param name="question">Question picked by program.</param>
    /// <param name="userText">User input as a string from the prompt questions.</param>
    public Entry(string prompt, string question, string userText)
    {
        _prompt = prompt;
        _question = question;
        _userText = userText;
    }

    
    //Constructor for ListingActivity.cs
    /// <summary>
    /// Constructor designed specifically for Listing Activity entries.
    /// </summary>
    /// <param name="prompt">Prompt picked by program.</param>
    /// <param name="userText">User input as a string from the prompt questions.</param>
    public Entry(string prompt, string userText)
    {
        _prompt = prompt;
        _userText = userText;
    }


    /// <summary>
    /// Adds the parameter entry into the _entry list. To use this properly, you must have a main Entry
    /// and then individual entries. The main entry should only have control over the list and writing
    /// files.
    /// </summary>
    /// <param name="entry">Individual entry must be used as a parameter.</param>
    public void AddToEntryList(Entry entry)
    {
        _entry.Add(entry);
    }


    /// <summary>
    /// Writes a file in the form of a text file with specific fields: prompt, question, entry.
    /// 3 Letter codes for parameters: lis is for ListingActivity (prompt and text.).
    /// ref is for ReflectingActivity (prompt, question and text entry).
    /// </summary>
    /// <param name="activity">Referenced to activity type in 3 letter code. Ref is reflecting activity,
    /// lis is listing activity.</param>
    public void WriteToFile(string activity)
    {
        //Random number between 100 and 9999 for no repeat filenaming.
        //Literally the first number I got out of this while testing destination locations was 666... :(
        //That is 1/999 or .001... right?
        Random newRan = new Random();
        int randomNum = newRan.Next(100, 999);
        //Two different file names for the different conditions.
        string fileLoc = @"output_files\";
        string fileRefName = $"{fileLoc}reflectingactivity{randomNum}.txt";
        string fileLisName = $"{fileLoc}listingactivity{randomNum}.txt";

        //keyword for ReflectingActivity filewriting.
        if (activity == "ref")
        {
            using (StreamWriter outputFile = new StreamWriter(fileRefName))
            {
                foreach (Entry entry in _entry)
                {
                    outputFile.WriteLine($"---- Entry from Reflecting Activity ----");
                    outputFile.WriteLine($"Prompt: {entry._prompt}");
                    outputFile.WriteLine($"Question: {entry._question}");
                    outputFile.WriteLine($"Text: {entry._userText}");
                    outputFile.WriteLine("-------------------------------------");
                }
            }
        }
        //keyword for ListingActivity filewriting.
        else if (activity == "lis")
        {
            using (StreamWriter outputFile = new StreamWriter(fileLisName))
            {
                foreach (Entry entry in _entry)
                {
                    outputFile.WriteLine($"---- Entry from Listing Activity ----");
                    outputFile.WriteLine($"Prompt: {entry._prompt}");
                    outputFile.WriteLine($"Text: {entry._userText}");
                    outputFile.WriteLine("-------------------------------------");
                }
            }
        }
    }
}