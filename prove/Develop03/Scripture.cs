using System.Data.SqlTypes;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

public class Scripture
{
    private List<Word> _words = new List<Word>();

    public void HideRandomWords(int newNumber, int maxLengthOfList) //newNumber is the random number from GenerateRandomNumber()
    {
        if (_words[newNumber].IsHidden() == true)
        {
            int anotherNewNumber = GenerateRandomNumber(maxLengthOfList);
            //Calls the method again internally to check if it's hidden again.
            HideRandomWords(anotherNewNumber, maxLengthOfList);
        }
        else if (_words[newNumber].IsHidden() == false)
        {
            _words[newNumber].Hide();
        }
    }


    public int GenerateRandomNumber(int maxLengthOfList)
    {
        Random newRandom = new Random();
        int newNumber = newRandom.Next(maxLengthOfList);

        return newNumber;
    }


    public string GetDisplayText()
    //This should basically display the "John 3:16 For God so loved the world..."
    {
        int countThisagain = 0;
        string newWordText = "";
        foreach (Word word in _words)
        {
            countThisagain += 1;
            newWordText += word.GetDisplayText() + " "; //I'm using the method to display the private _text;
        }
        return newWordText;
        throw new InvalidOperationException("No new Words found");
    }


    public bool IsCompletelyHidden(int maxLengthOfList)
    {
        int checker = 0;
        bool checkThisBool = false;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                //Add to the checker count.
                checker += 1;
            }
            else
            {
                checker += 0;
            }
        }
        if (checker == maxLengthOfList)
        {
            checkThisBool = true;
        }
        //If checker equals the length of the list (or if everything is IsHidden() = true)
        // then return the IsCompletelyHidden bool as true.
        
        return checkThisBool;
    }


    public Scripture(){ }

    public void AddToScriptureList(Word newWord)
    {
        _words.Add(newWord);
    }
}