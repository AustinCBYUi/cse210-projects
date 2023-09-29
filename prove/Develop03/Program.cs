using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference newScriptureToStudy = new Reference();
        //Change the data below only! This should be temporary \\
        string myBook = "John";
        string myScripture = $"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should\nnot perish, but have everlasting life.";
        int myChapter = 3;
        int myVerse = 16;
        int myEndVerse = 0;
        // Change the data above ONLY \\
        Word newText = new Word(myScripture);
        newScriptureToStudy.SetReferenceData(myBook, myChapter, myVerse, myEndVerse);
        Console.WriteLine(newScriptureToStudy.GetDisplayText() + " " + newText.GetDisplayText());

        Console.WriteLine("\nPress Enter to remove words from scripture or type 'quit' to exit.\n");

    }
}