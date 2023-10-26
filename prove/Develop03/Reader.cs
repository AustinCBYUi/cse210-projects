using System.IO;
using System.Linq;

/// <summary>
/// Represents the heavy lifter of the program. Reads and transmits data from the text file.
/// </summary>
public class Reader
{
    private int _maxLength;

    Scripture newScripture = new Scripture();
    Reference createNewReference = new Reference();


    /// <summary>
    /// Recieves data from the text file and sends it to the SendData() method internally.
    /// </summary>
    /// <param name="newFile">The file the method will be reading.</param>
    public void GetDataFromTxt(string newFile)
    {
        string filename = newFile;
        string[] lines = File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            int endVerse = int.Parse(parts[3]);
            string text = parts[4];
            SendData(book, chapter, verse, text, endVerse);
        }
    }


    /// <summary>
    /// Sends the data to the instances created of Scripture and Reference.
    /// </summary>
    /// <param name="book">String of book name</param>
    /// <param name="chapter">Chapter of the book as an integer.</param>
    /// <param name="verse">Verse of the book as an integer.</param>
    /// <param name="text">Text of the scripture as a string.</param>
    /// <param name="endVerse">Optional end verse as a integer.</param>
    public void SendData(string book, int chapter, int verse, string text, int endVerse)
    {
        createNewReference.SetReferenceData(book, chapter, verse, endVerse);

        int maxLength = 0;
        //For each word in the string, add each word to the Word class as a new word.
        foreach (string word in text.Split(" "))
        {
            Word eachNewWord = new Word(word);
            //Should add each new Word object to the <Word> list.
            newScripture.AddToScriptureList(eachNewWord);
            //Count each iteration to provide the new length of the list.
            maxLength += 1;
        }
        _maxLength = maxLength;
    }


    /// <summary>
    /// Getter for max length of the scripture. Used to calculate IsCompletelyHidden()
    /// </summary>
    /// <returns>Max length of the scripture as an integer.</returns>
    public int GetMaxLength()
    {
        return _maxLength;
    }


    /// <summary>
    /// Getter for the Scripture instance that is created in the Reader class.
    /// </summary>
    /// <returns>newScripture instance to transfer data.</returns>
    public Scripture GetScripture()
    {
        return newScripture;
    }


    /// <summary>
    /// Getter for the Reference instance that is created in the Reader class.
    /// </summary>
    /// <returns>createNewReference instance to transfer data.</returns>
    public Reference GetReference()
    {
        return createNewReference;
    }
}