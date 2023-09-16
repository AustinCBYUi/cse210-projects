using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
//Practice
        // if (x > y)
        // {
        //     Console.WriteLine("greater than");
        // }
        /*
nested if statements.
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("Greater than both");
            }
        } 

if, else if, and else conditional
        if (x > y)
        {
            Console.WriteLine("Greater than y");
        }
        else if (x > z)
        {
            Console.WriteLine("Greater than Z");
        }
        else
        {
            Console.WriteLine("less than both");
        }

Operators, (supports operators from python like !=, >=, <=, ==)
        if (name == "John")
        {
            Console.WriteLine("The name is John");
        }

        if (color != favoriteColor)
        {
            Console.WriteLine("That color is not my favorite");
        }

And (&&), or (||) and not (!) operators combined
OR
        if (name == "Peter" || name == "James" || name == "John")
        {
            Console.WriteLine("This is a biblical name.");
        }

AND
        if (firstName == "Brigham" && lastName == "Young")
        {
            Console.WriteLine("Welcome Brother Brigham!");
        }
    
NOT
        if (!(name == "Peter" || name == "James" || name == "John"))
        {
            Console.WriteLine("This is not one of those three");
        }


Variables and Types (only a few of the types here)
        string color;
        string firstName;
        string lastName;
        int velocityBeforeImpactWasMade;
Converting types
        string valueInText = "42";
        int number = int.Parse(valueInText);
Input with conversion
strings to numbers
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
numbers to strings
        int number = 42;
        string textVersion = number.ToString();


--------- Lists --------
        List<int> numbers = new List<int>();
        List<string> words = new List<string>();

Adding to lists
        numbers.Add(9);
        numbers.Add(16);
        words.Add("Hello");

Use Count to get all items in a list
        Console.WriteLine(words.Count);

Easiest and safest way to iterate through a list is to use a foreach loop.
        foreach (string word in strings)
        {
            Console.WriteLine(word);
        }

Can also access the items by their index.
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        */
    }
}