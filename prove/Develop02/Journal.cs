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
        int count = 0;
        foreach (Entry entry in _entries)
        {
            count += 1;
            Console.WriteLine($"\nJournal Entry #{count}");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Response:\n{entry._entryText}\n");
        }
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        
    }
}