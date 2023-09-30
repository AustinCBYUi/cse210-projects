using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }


    public string GetDisplayText()
    //This should basically display the "John 3:16 For God so loved the world..."
    {
        int countThisagain = 0;
        string newWordText = "";
        foreach (Word word in _words)
        {
            countThisagain += 1;
            newWordText += word.Show() + " "; //I'm using the .Show() method to display the private _text;
        }
        return newWordText;
        throw new InvalidOperationException("No new Words found");
    }


    public bool isCompletelyHidden()
    {
        return true;
    }


    public Scripture(){ }

    public void AddToScriptureList(Word newWord)
    {
        _words.Add(newWord);
    }
}