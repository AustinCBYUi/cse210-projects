using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //New reader.
        Reader readFromFile = new Reader();
        //newScripture is the INSTANCE from the readFromFile class, so this isn't a constructor.
        Scripture newScripture = readFromFile.GetScripture();
        //Same with this one, not a constructor. It just gets the instance from the reader class
        //that was already created there.
        Reference newReference = readFromFile.GetReference();

        //Text file we will read from.
        string readFromScripturesFile = "scriptures.txt";
        //Call method in the class with the file as the parameter.
        readFromFile.GetDataFromTxt(readFromScripturesFile);
        //maxLength comes from the reader file as well now.
        int maxLength = readFromFile.GetMaxLength();

        //Just for the loop when you type 'quit', default is notquit.
        string userInput = "notquit";

        //Main portion, while loop for program-user functionality.
        while (userInput != "quit")
        {
            //Write prompt with reference data first, then the scripture text.
            Console.WriteLine($"{newReference.GetDisplayText()} {newScripture.GetDisplayText()}");
            Console.Write("Press enter to remove words, 'quit' to quit.\n");
            string getUserInput = Console.ReadLine().ToLower();
            //Should be false until list is completely hidden.
            bool isTheListDone = newScripture.IsCompletelyHidden(maxLength);
            
            //Conditionals for program logic.
            if (getUserInput == "quit")
            {
                userInput = "quit";
                Exit();
            }
            //If the list is completely hidden, it will close the program.
            else if (isTheListDone == true)
            {
                userInput = "quit";
                Exit();
            }
            //If program is not completely hidden
            else if (isTheListDone != true)
            {
                //Clear the console so user can't cheat.
                Console.Clear();
                //Always starting with numbers 1, and 4.
                newScripture.HideRandomWords(1, maxLength);
                newScripture.HideRandomWords(4, maxLength);
            }
        }
    }

    
    /// <summary>
    /// Exits the program with no exit code.
    /// </summary>
    private static void Exit()
    {
        System.Environment.Exit(0);
    }
}