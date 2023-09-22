using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator newPrompt = new PromptGenerator();
        string promptForEntry = newPrompt.GetRandomPrompt();
        
        Console.WriteLine(promptForEntry);

        Journal newJournal = new Journal();

        Entry newEntry = new Entry();


        Console.WriteLine("Journal Options:");
        Console.WriteLine("1) Write Entry");
        Console.WriteLine("2) Display All Entries");
        Console.WriteLine("3) Save to File");
        Console.WriteLine("4) Load");
        Console.WriteLine("5) Exit");

        int userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            //WriteEntry
            Console.WriteLine(promptForEntry);
            Console.Write("> ");
            string userJournalEntry = Console.ReadLine();
            newEntry._entryText = userJournalEntry;
        }
        else if (userInput == 2)
        {
            //Display all written entries
        }
        else if (userInput == 3)
        {
            //Save to file
        }
        else if (userInput == 4)
        {
            //Load file
        }
        else
        {
            //Exit the program.
        }
    }
    //End of MainDisplay()
}