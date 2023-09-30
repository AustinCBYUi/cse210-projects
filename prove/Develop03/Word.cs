using System.Runtime.InteropServices;

public class Word
{ //{Word} | Attributes : bool / _isHidden t/f \\ _text : string stores each actual word as a string.
    private string _text;
    private bool _isHidden;


    public void Hide()
    {
        foreach (char letter in _text)
        {
            var DONOTREPLACE_PERIOD = '.';
            var DONOTREPLACE_COMMA = ',';
            //VAR IS IN C#??
            if (_isHidden != true)
            {
                if (letter != DONOTREPLACE_PERIOD || letter != DONOTREPLACE_COMMA)
                {
                    var replace = _text.Replace(letter, '_');
                    _text = replace;
                }
                else
                {
                    var replace = _text.Replace(letter, '_');
                }
            }
        }
        _isHidden = true;
    }


    public string Show()
    {
        return _text;
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