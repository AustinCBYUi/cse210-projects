using System.IO;
using Microsoft.Win32.SafeHandles;

public class Scripture
{
    public List<string> _scriptures = new List<string>();
    private string _book;
    private string _chapter;
    private string _verse;

    private void GenerateScripture()
    {
        string fileName = "prove\\Develop03\\scriptures.txt";
        // try
        // {
            // StreamReader fileInput = new StreamReader(fileName);
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("-");

                _book = parts[0];
                _chapter = parts[1];
                _verse = parts[2];
                _scriptures = _scriptures.Add(parts[3]);
            }
            // line = fileInput.ReadLine();

            // while (line != null)
            // {
            //     _scriptures.Add(line);
            //     line = fileInput.ReadLine();
            // }
            // fileInput.Close();
            
        // }
        // finally
        // {
        //     Console.WriteLine("Finished");
        // }
    }

    public string WriteScripturesToConsole()
    {
        return $"{_book} {_chapter}:{_verse} - {_scriptures}";
    }
}