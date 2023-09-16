using System;

/*
* Writing functions is a favorite of mine, so looking forward to learning methods!
* C# is very clean, straight to the point, and feels to be possible of anything compared to Python.
* Austin Campbell
*/

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredFavNum = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredFavNum);


        //Displays welcome message. No return hence the void.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }


        //Prompts for a username, returns a string.
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name ");
            string userName = Console.ReadLine();

            return userName;
        }


        //Prompts for a user favorite number, returns a integer.
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int favoriteNumber = int.Parse(Console.ReadLine());

            return favoriteNumber;
        }


        //Squares the number that is provided above, returns an integer.
        static int SquareNumber(int integer)
        {
            int squared = integer * integer;

            return squared;
        }


        //Simply displays results from all the other functions, doesn't return anything.
        static void DisplayResult(string userName, int squaredFavoriteNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredFavoriteNumber}.");
        }
    }
}