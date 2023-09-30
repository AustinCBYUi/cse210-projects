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

        Console.WriteLine("Scripture Memorizer!");
        Console.WriteLine(getScripture.GetDisplayText());
        while (userInput != "quit")
        {
            Console.Write("");
            string getUserInput = Console.ReadLine().ToLower();
            
            if (getUserInput == "quit")
            {
                userInput = "quit";
            }
            else
            {
                Random randomNumber = new Random();
                int random = randomNumber.Next(maxLength);
                //presses enter
                getScripture.HideRandomWords(random);
                getScripture.GetDisplayText();
            }
            Console.WriteLine(getScripture.GetDisplayText());
        }
    }
}
        /*
        Word getString = new Word(myScripture);
        Scripture newScripture = new Scripture();
        //This loop creates a new Word() object for each iteration through the string.
        int counter = 0;
        foreach (string word in myScripture.Split(" "))
        {
            Word newEachWord = new Word(word.ToString());
            //Accessor to add to PRIVATE list.
            newScripture.AddToScriptureList(newEachWord);
            //Took me two hours how to figure out how I was storing data here vvv.. :/
            //good news is i figured it out finally.
            //TODO: Note - i must access the _words list at [index] to access the _text string,
            //otherwise it won't work. so using the counter is a good way to display the list for
            //testing but i will need to figure it out another way tomorrow.
            counter += 1;
        }
        newScriptureToStudy.SetReferenceData(myBook, myChapter, myVerse, myEndVerse);
        Console.WriteLine(newScriptureToStudy.GetDisplayText() + " " + getString.GetDisplayText());
        newScripture.GetDisplayText(myScripture);

        Console.WriteLine("\nPress Enter to remove words from scripture or type 'quit' to exit.\n");

    }
}*/