/// <summary>
/// References the data of the scripture such as chapter, verse, etc..
/// </summary>
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


/// <summary>
/// Formats the information of the scripture.
/// </summary>
/// <returns>Scripture Book Chapter:Verse(-End verse if referenced)</returns>
    public string GetDisplayText()
    {
        string display;
        if (_endVerse == 0)
        {
            display = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            display = $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
        }
        return display;
    }


/// <summary>
/// Sets the reference data of the scripture.
/// </summary>
/// <param name="book">Book name as a string</param>
/// <param name="chapter">Book chapter as an integer.</param>
/// <param name="verse">Book verse as an integer.</param>
/// <param name="endVerse">Optional book verse as an integer, set to 0 as default..</param>
    public void SetReferenceData(string book, int chapter, int verse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
}