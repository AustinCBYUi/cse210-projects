using System.Runtime.CompilerServices;
/// <summary>
/// Abstract class of a physical journal. 
/// </summary>
/// <remarks>
/// Attributes: _entries
/// _entries is a list that is defined from the Entry class.
/// Methods: AddEntry(string) : void
/// DisplayAll() : void
/// saveToFile(string file name) : void
/// loadFromFile(string file name) : void
/// </remarks>

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

//TODO: All these methods
    public void AddEntry(Entry newEntry)
    {
        
    }

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

    public void SaveToFile(string file)
    {
        //Should save to a .txt file with a name that is specified
        //by the user.

        /* //This is what I wrote earlier, will work on this method in full next.
        Console.WriteLine("Filename: ");
        string fileName = Console.ReadLine();

        _date = "09/21/2023";
        //Maybe this doesn't belong here, try in Journal class.
        string newEntryFile = $"{fileName}.txt";
        using (StreamWriter outputFile = new StreamWriter(newEntryFile))
        {
            outputFile.WriteLine($"Date: {_date}\n");
            outputFile.WriteLine($"Prompt: {_promptText}");
            outputFile.WriteLine($"Entry: {_entryText}");
            // newJournal.AddEntry(newEntryFile);
        */
    
    }

    public void LoadFromFile(string file)
    {
        
    }
}