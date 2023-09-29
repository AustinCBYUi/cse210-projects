public class Word
{ //{Word} | Attributes : bool / _isHidden t/f \\ _text : string stores each actual word as a string.
    public string _text;
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
}