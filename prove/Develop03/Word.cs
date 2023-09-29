public class Word
{
    private string _text;
    private bool _isHidden;


    public void Hide()
    {

    }


    public void ShoW()
    {

    }


    public bool IsHidden()
    {
        return true;
    }


    public string GetDisplayText()
    {
        return _text;
    }


    public Word(string newText)
    {
        _text = newText;
    }

    public Word(Word newWord)
    {
        foreach (Word word in newWord)
        {
            
        }
    }
}