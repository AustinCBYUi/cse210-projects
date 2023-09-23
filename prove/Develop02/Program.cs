using System;
using System.Runtime.CompilerServices;

/*
* This was oddly tough for me at first, but I enjoyed the stress and
* having to go out of my comfort zone.
* I have used Switch and Cases before in C++, but did have to research that.
* I used a Discord page I am apart of called The Coding den to get a bit of help
* on the instance issues I was running into.
*/

class Program
{
    static void Main(string[] args)
    {
        //Initialization
        Journal newJournal = new Journal();
        //Get Date
        DateTime getToday = DateTime.Now;
        string todaysDate = getToday.ToShortDateString();
        
        //Boolean for while loop.
        bool userExitProgram = false;


        //While userExitProgram is not true..
        while (userExitProgram != true)
        {
            //Instance a new entry every time loop is engaged?
            Entry newEntry = new Entry();

            //Initializing new prompt
            PromptGenerator newPrompt = new PromptGenerator();
            string promptForEntry = newPrompt.GetRandomPrompt();

            //Start Menu selection.
            Console.WriteLine("Journal Options:");
            Console.WriteLine("1) Write Entry");
            Console.WriteLine("2) Display All Entries");
            Console.WriteLine("3) Save to File");
            Console.WriteLine("4) Load");
            Console.WriteLine("5) Exit");

            //userInput from menu selection
            int userInput = int.Parse(Console.ReadLine());
            //For the switch
            switch(userInput)
            {
                //Write Entry is Case 1.
                case 1:
                    //Display the Prompt
                    Console.WriteLine(promptForEntry);
                    //Just a carrot for looks here + input line
                    Console.Write("++ ");
                    //new variable that is the user's entry for the Journal
                    string userJournalEntry = Console.ReadLine();
                    //Update the newEntry instance attribute _entryText to be what the user's input was.
                    newEntry._entryText = userJournalEntry;
                    //Add the date to the instance and the prompt.
                    newEntry._date = todaysDate;
                    newEntry._promptText = promptForEntry;
                    //should add the attributes to the newJournal list
                    newJournal._entries.Add(newEntry);
                    break;
                //Display all currently written Entries is Case 2.
                case 2:
                    //Display all written entries
                    // newEntry.Display();
                    newJournal.DisplayAll();
                    break;
                //Save to a file is Case 3.
                case 3:
                    //Save to file. User defines a file
                    Console.Write("Type a Filename, exclude extension: ");
                    //Read user input
                    string newUserDefinedFile = Console.ReadLine();
                    //Add .txt to the end of it as the extension.
                    newUserDefinedFile = $"{newUserDefinedFile}.txt";

                    //Call method with the newJournal instance
                    newJournal.SaveToFile(newUserDefinedFile);
                    break;
                //Load from a file is Case 4
                case 4:
                    //Needs to load from file
                    Console.Write("Type a Filename you created: ");
                    //Read user input
                    string newUserFoundFile = Console.ReadLine();
                    newUserFoundFile = $"{newUserFoundFile}.txt";

                    newJournal.LoadFromFile(newUserFoundFile);
                    break;
                //Just exit the program is Case 5.
                case 5:
                    userExitProgram = true;
                    break;
            }
        }
    }
}