using System.Net.Mail;
using System.IO;
using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine("Journal Entry.");
        Console.WriteLine($"Date: {_date}.");
        Console.WriteLine($"Prompt: {_promptText}.");
        Console.WriteLine($"Your Response:\n{_entryText}\n");
    }
}

/*
You can create or write a text file in C# using a class the System.IO.StreamWriter class. When you create an object of this class you can use the Write() and WriteLine() methods in the same way as the Console.Write() methods, except that they will write the strings to the file instead of to the Console.

To make sure the file gets closed and cleaned up appropriately when you are done, it is best practice to put the StreamWriter object in a using() block. This works the same as a "with" block in Python and ensures that the resources are cleaned up when you leave that area of the code.

The following shows an example of writing text to a new file


// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 

...

string fileName = "myFile.txt";

using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
    */