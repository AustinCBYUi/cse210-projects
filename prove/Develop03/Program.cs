using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Scripture testme = new Scripture();
        Reference newScriptureToStudy = new Reference();
        Scripture getScripture = new Scripture();

        //Change the data below only! This should be temporary \\
        string myBook = "John";
        string myScripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should\nnot perish, but have everlasting life.";
        int myChapter = 3;
        int myVerse = 16;
        int myEndVerse = 0;
        // Change the data above ONLY \\

        newScriptureToStudy.SetReferenceData(myBook, myChapter, myVerse, myEndVerse);
        string userInput = "notquit";

        int maxLength = 0;
        //For each word in the string, add each word to the Word class as a new word.
        foreach (string word in myScripture.Split(" "))
        {
            Word eachNewWord = new Word(word);
            //Should add each new Word object to the <Word> list.
            getScripture.AddToScriptureList(eachNewWord);
            //Count each iteration to provide the new length of the list.
            maxLength += 1;
        }
        while (userInput != "quit")
        {
            Console.WriteLine($"{newScriptureToStudy.GetDisplayText()} {getScripture.GetDisplayText()}");
            Console.Write("Press enter to remove words, 'quit' to quit.\n");
            string getUserInput = Console.ReadLine().ToLower();
            bool isTheListDone = getScripture.IsCompletelyHidden(maxLength);
            
            if (getUserInput == "quit")
            {
                userInput = "quit";
            }
            else if (isTheListDone == true)
            {
                userInput = "quit";
                System.Environment.Exit(0);
            }
            else if (isTheListDone != true)
            {
                Console.Clear();
                //Always starting with numbers 1, and 4.
                getScripture.HideRandomWords(1, maxLength);
                getScripture.HideRandomWords(4, maxLength);
            }
        }
    }
}