using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Initializing
        PromptGenerator newPrompt = new PromptGenerator();
        string promptForEntry = newPrompt.GetRandomPrompt();
        
        //Tester line, remove ASAP -------------------------------
        Console.WriteLine(promptForEntry);

        //Initialization
        Journal newJournal = new Journal();

        Entry newEntry = new Entry();
        
        //Boolean for while loop.
        bool userExitProgram = false;

        //While userExitProgram is not true..
        while (userExitProgram != true)
        {
            //Start Menu selection.
            Console.WriteLine("Journal Options:");
            Console.WriteLine("1) Write Entry");
            Console.WriteLine("2) Display All Entries");
            Console.WriteLine("3) Save to File");
            Console.WriteLine("4) Load");
            Console.WriteLine("5) Exit");

            //userInput from menu selection
            int userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                //WriteEntry
                Console.WriteLine(promptForEntry);
                Console.Write("@ ");
                //Entry newEntry = new Entry(); Don't need to be here.
                //new variable that is the user's entry for the Journal
                string userJournalEntry = Console.ReadLine();
                //Update the newEntry object's attribute _entryText to be what the user's input was.
                newEntry._entryText = userJournalEntry;
                newEntry._date = "09/22/2023";
                newEntry._promptText = userJournalEntry;
                //should add the attributes to the newJournal
                newJournal._entries.Add(newEntry);
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
                userExitProgram = true;
            }
        }
    //End of MainDisplay()
    }
}