using System;

class Program
{
    static void Main(string[] args)
    {
        //First Name with input.
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        //Last name with input
        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();

        //f-string to put them together.
        Console.WriteLine($"Your name is {last}, {first}.");
        //Testing, useless syntax
        // Console.WriteLine("Your name is " + last + ", " + first + ".");
    }
}