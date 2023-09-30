public class Word
{ //{Word} | Attributes : bool / _isHidden t/f \\ _text : string stores each actual word as a string.
    private string _text;
    private bool _isHidden;

/// <summary>
/// Hide the individual letters in the Word object and replace them with underscores.
/// </summary>
    public void Hide()
    {
        foreach (char letter in _text)
        {
            if (letter == '.')
            {
                var doNotReplace = _text.Replace(letter, '.');
            }
            else if (letter == ',')
            {
                var doNotReplace = _text.Replace(letter, ',');
            }
            var replace = _text.Replace(letter, '_');
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