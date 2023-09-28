using System.Runtime.CompilerServices;
using System.IO;


/// <summary>
/// Abstract class of a physical journal. 
/// </summary>
/// <remarks>
/// Attributes: _entries
/// _entries is a list that is defined from the Entry class.
/// Methods:
/// DisplayAll() : void
/// saveToFile(string fileName) : void
/// loadFromFile(string fileName) : void
/// </remarks>

public class Journal
{
    public List<Entry> _entries = new List<Entry>();



/// <summary>
/// DisplayAll() : void - method to display all content in the _entries list. Built in counter to count
/// each entry that is iterated through.
/// </summary>
/// <remarks>
/// Displays to console in format: count, _date, _promptText, _entryText from newEntry.
/// </remarks>
    public void DisplayAll()
    {
        //Just wanted the Entry numbers to be counted. This method would only
        //be stored off memory. Once you use the saveToFile() method, you would
        //need to loadFromFile() to get the old entry.
        int count = 0;
        //For loop with the Entry datatype and entry object as a variable which loops
        //through the _entries list.
        foreach (Entry entry in _entries)
        {
            //Add to count
            count += 1;
            //Just display stuff for console.
            Console.WriteLine($"\nJournal Entry #{count}");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Response:\n{entry._entryText}\n");
        }
    }


/// <summary>
/// Creates a file to the root folder with the user's input as a filename.
/// File automatically created as .txt extension. No return, takes a string file name
/// as a parameter. File is also formatted accordingly: ----Sep----, Entry#, Date, Prompt, Entry
/// </summary>
/// <param name="file">String as a parameter which is the file.txt</param>
    public void SaveToFile(string file)
    {
        //Should save to a .txt file with a name that is specified
        //by the user.
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            int count = 0;
            foreach (Entry entry in _entries)
            {
                count += 1;
                //Separator
                outputFile.WriteLine("-----------------------------");
                //Entry number
                outputFile.WriteLine($"Entry #{count}");
                //Entry information
                outputFile.WriteLine($"Date: {entry._date}");
                outputFile.WriteLine($"Prompt: {entry._promptText}");
                outputFile.WriteLine($"User Entry: {entry._entryText}\n");
            }
        }
        Console.WriteLine($"\nSuccessfully wrote {file}.\n");
    }


/// <summary>
/// Loads from a file that is in the root directory. Changes no formatting of the pre-existing file.
/// </summary>
/// <param name="file">String as a parameter which is the file.txt</param>
    public void LoadFromFile(string file)
    {
        //Already using System.IO otherwise it would be..
        //System.IO.File.ReadAllLines(filenameHere);

        //This works just reading the file? I already formatted it when it was written
        // so perhaps that is why? No need to use a loop, this works great.
        string lines = File.ReadAllText(file);

        Console.WriteLine(lines);
    }
}