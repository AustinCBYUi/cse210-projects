public class Entry : Activity
{
    internal List<Entry> _entry = new List<Entry>();
    internal string _prompt;
    internal string _question;
    internal string _userText;


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