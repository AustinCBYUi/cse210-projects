using System.Text;
/// <summary>
/// Represents a word as a string.
/// </summary>
public class Word
{ //{Word} | Attributes : bool / _isHidden t/f \\ _text : string stores each actual word as a string.
    private string _text;
    private bool _isHidden;

/// <summary>
/// Hide the individual letters in the Word object and replace them with underscores.
/// </summary>
    public void Hide()
    {
        char period = '.';
        char comma = ',';
        foreach (char letter in _text)
        {
            StringBuilder newString = new StringBuilder();
            //VAR IS IN C#??
            if (_isHidden != true)
            {
                if (letter != period && letter != comma)
                {
                    var replace = _text.Replace(letter, '_');
                    newString.Append(replace);
                }
                else if (letter == comma)
                {
                    var replace = _text.Replace(letter, comma);
                    newString.Append(replace);
                }
                else if (letter == period)
                {
                    var replace = _text.Replace(letter, period);
                    newString.Append(replace);
                }
            }
            _text = newString.ToString();
        }
        _isHidden = true;
    }


/// <summary>
/// Checks if the Word object has been set to hidden or not as a boolean.
/// </summary>
/// <returns>True/False</returns>
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


/// <summary>
/// Practicing encapsulation, this method returns the private string of the Word.
/// </summary>
/// <returns>String</returns>
    public string GetDisplayText()
    {
        return _text;
    }


/// <summary>
/// Constructor to create a new Word with the parameter as the text.
/// </summary>
/// <param name="newText">New text for the newly constructed object.</param>
    public Word(string newText)
    {
        _text = newText;
    }
}