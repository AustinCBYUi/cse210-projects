using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
        //Helping example for T-grizz
    static void Main(string[] args)
    {
        //Constant named pi, never changing value.
        double PI = 3.14159;

        //Introduction to the 'calculator'
        Console.WriteLine("Type a shape to calculate the area of it!");
        //Reads the line, and also converts all characters to lowercase to simplify things.
        string userInput = Console.ReadLine().ToLower();

        //Need to convert the switch to integers apparently.
        //I set the switchAssigner to -1
        int switchAssigner = 0;

        //You could probably do this another way, but I am just helping.
        //Then if you type a square, it gets set to 1
        if (userInput == "circle")
        {
                switchAssigner = 1;
        }
        //If you type a circle it equals 2.
        else if (userInput == "square")
        {
                switchAssigner = 2;
        }
        //lastly, if you type a rectangle it is 3!
        else if (userInput == "rectangle")
        {
                switchAssigner = 3;
        }
        //Just a way to catch other shit you may type.
        else
        {
                Console.WriteLine("You messed up to get here..");
        }


        //Switch with switchAssigner as my switch.
        switch(switchAssigner)
        {
                //Circle case
                case 1:
                        Console.WriteLine("Radius of Circle: ");

                        double radius = double.Parse(Console.ReadLine());
                        //Order of operations first goomba,
                        //Exponents comes before multiplication.
                        double squareRadius = Math.Pow(radius, 2);
                        double answerCircle = PI * squareRadius;

                        Console.WriteLine($"Area of your circle: {answerCircle}.");
                break;
                //Square
                case 2:
                        Console.WriteLine("Length of a side: ");
                        double squareSide = double.Parse(Console.ReadLine());

                        double answerSquare = Math.Pow(squareSide, 2);

                        Console.WriteLine($"Area of your square: {answerSquare}");
                break;
                //Rectangle
                case 3:
                        Console.WriteLine("Width: ");
                        double rectangleWidth = double.Parse(Console.ReadLine());
                        Console.WriteLine("Length: ");
                        double rectangleLength = double.Parse(Console.ReadLine());

                        double answerRectangle = rectangleWidth * rectangleLength;

                        Console.WriteLine($"Area of your rectangle: {answerRectangle}");
                break;
        }
    }
}


//---------------- BELOW HERE IS NOTES --------------\\

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



---------- Functions -----------
You call what is being returned right there with returnType. Always use TitleCase for functions.
        returnType FunctionName(dataType parameter1, dataType parameter2)
        {
            // function_body
        }

doesn't return anything using 'void'
        void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
        }

Accepts a single string parameter
        void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}.");
        }

This function adds two numbers together and returns a result as an int as shown
        int AddNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

To define a standalone function that doesn't use any other context.
        static void DisplayMessage()
        {
            Console.WriteLine("Hello World");
        }

        static void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello there {userName}!");
        }

Returns an int
        static int AddNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        */