using System.Data.SqlTypes;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

/// <summary>
/// Represents a list of Word words as a scripture which can be manipulated.
/// </summary>
public class Scripture
{
    private List<Word> _words = new List<Word>();


/// <summary>
/// Hides random words from the private list of Word words.
/// </summary>
/// <param name="newNumber">The index number in the list.</param>
/// <param name="maxLengthOfList">The max length of the list used to cap the random numbers.</param>
    public void HideRandomWords(int newNumber, int maxLengthOfList)
    {
        //If the Word object at this index is hidden then we will generate a new one and try again.
        if (_words[newNumber].IsHidden() == true)
        {
            int anotherNewNumber = GenerateRandomNumber(maxLengthOfList);
            //Calls the method again internally to check if it's hidden again.
            HideRandomWords(anotherNewNumber, maxLengthOfList);
        }
        //Otherwise if it is not hidden, we will hide it.
        else if (_words[newNumber].IsHidden() == false)
        {
            _words[newNumber].Hide();
        }
    }


/// <summary>
/// Random number generator built into the Scripture class.
/// </summary>
/// <param name="maxLengthOfList">Max number the random number generator can use.</param>
/// <returns>A random number named newNumber</returns>
    public int GenerateRandomNumber(int maxLengthOfList)
    {
        Random newRandom = new Random();
        int newNumber = newRandom.Next(maxLengthOfList);

        return newNumber;
    }


/// <summary>
/// Formats the Word objects into a StringBuilder to re-compose the scripture.
/// </summary>
/// <returns>A StringBuilder named newWordText</returns>
/// <exception cref="InvalidOperationException">The computer couldn't find new words in the list.</exception>
    public StringBuilder GetDisplayText()
    //This should basically display the "John 3:16 For God so loved the world..."
    {
        // Found out concatenated strings is bad form to use.
        StringBuilder newWordText = new StringBuilder();
        foreach (Word word in _words)
        {
            newWordText.Append(word.GetDisplayText() + " "); //I'm using the method to display the private _text;
        }
        return newWordText;
        throw new InvalidOperationException("No new Words found");
    }


/// <summary>
/// Checks to see if every word in the list of Words is all hidden via booleans.
/// </summary>
/// <param name="maxLengthOfList">Max number of the string</param>
/// <returns>True/False</returns>
    public bool IsCompletelyHidden(int maxLengthOfList)
    {
        //Checker to make sure we get the same amount of words
        int checker = 0;
        //Set to false to manipulate in the loop.
        bool checkThisBool = false;
        foreach (Word word in _words)
        {
            //If it is hidden ->
            if (word.IsHidden() == true)
            {
                //Add to the checker count.
                checker += 1;
            }
            //If it's not hidden yet, don't count it.
            else
            {
                checker += 0;
            }
        }
        //Outside the loop, check at the end of every method call if the checker is equal to
        //maxlength, if it is: every item in the list should be hidden.
        if (checker == maxLengthOfList)
        {
            checkThisBool = true;
        }
        //If checker equals the length of the list (or if everything is IsHidden() = true)
        // then return the IsCompletelyHidden bool as true.
        
        return checkThisBool;
    }


/// <summary>
/// Adds a new Word to the scripture list.
/// </summary>
/// <param name="newWord">A new word as a Word object.</param>
    public void AddToScriptureList(Word newWord)
    {
        _words.Add(newWord);
    }
}