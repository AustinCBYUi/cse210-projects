using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

public class Scripture
{
    public List<Word> _words = new List<Word>();
    private Reference _reference;

    private void HideRandomWords(int numberToHide)
    {

    }


    public string GetDisplayText()
    //This should basically display the "John 3:16 For God so loved the world..."
    {
        return "";
    }


    public bool isCompletelyHidden()
    {
        return true;
    }
}