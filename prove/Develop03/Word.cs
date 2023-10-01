public class Word
{ //{Word} | Attributes : bool / _isHidden t/f \\ _text : string stores each actual word as a string.
    private string _text;
    private bool _isHidden;

/// <summary>
/// Hide the individual letters in the Word object and replace them with
/// </summary>
    public void Hide()
    {
        char period = '.';
        char comma = ',';
        foreach (char letter in _text)
        {
            string newString = "";
            //VAR IS IN C#??
            if (_isHidden != true)
            {
                if (letter != period && letter != comma)
                {
                    var replace = _text.Replace(letter, '_');
                    newString += replace;
                }
                else if (letter == comma)
                {
                    var replace = _text.Replace(letter, comma);
                    newString += replace;
                }
                else if (letter == period)
                {
                    var replace = _text.Replace(letter, period);
                    newString += replace;
                }
            }
            _text = newString;
        }
        _isHidden = true;
    }


    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
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