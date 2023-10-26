using System;

/*
* @Author is Austin Campbell@
* Feel like I'm grasping C# pretty good and am enjoying it. Looking forward to rewriting a few applications using
* the .NET framework instead of using Python. So far I feel like C# is significantly more 'programmed' than Python.
*
* Checked the instructor code. @@THIS - guess = int.Parse(Console.ReadLine());
* Definitely a simpler approach than mine ^^
*/

class Program
{
    static void Main(string[] args)
    {
        //Default response is yes to start the game.
        string response = "yes";

        //While loop for the entire game.
        while (response == "yes")
        {
            //Generate a random number named magicNumber.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 10);

            //Game Header / directions.
            Console.WriteLine("Pick a number between 1 and 10.");

            //boolean for the do-while loop.
            bool endOfGame = false;
            //Declare number of guesses outside of loop starting at 0.
            int numOfGuesses = 0;

            //Do the following while endOfGame is not equal to true.
            do
            {
                //Get the users guess.
                Console.WriteLine("What is your guess? ");
                //Has to be a string from the console. But it needs to be converted.
                string guessedNumberString = Console.ReadLine();
                //Convert the user guess into a int.
                int guessedNum = int.Parse(guessedNumberString);

                //Start of conditionals.
                //If the user's guessed number is less than the magic number, we will print "too low"
                if (guessedNum < magicNumber)
                {
                    //Increment numOfGuesses
                    numOfGuesses += 1;
                    Console.WriteLine("Too low!");
                }
                //else if the guessed number is greater than magic number then print "too high"
                else if (guessedNum > magicNumber)
                {
                    //Increment numOfGuesses
                    numOfGuesses += 1;
                    Console.WriteLine("Too high!");
                }
                //else if you guess the number you'll get a Nice job print and the boolean will change to true.
                else if (guessedNum == magicNumber)
                {
                    Console.WriteLine($"Nice job! You used {numOfGuesses} guesses.");
                    endOfGame = true;
                }
                //Catching exceptions?
                else
                {
                    Console.WriteLine("Not sure how we ended up here. You probably typed a letter or special char.");
                }
            } while (endOfGame != true);
            //To continue the big while loop.
            Console.WriteLine("Do you want to play again? ");
            //Gets response and converts it to all lowercase.
            response = Console.ReadLine().ToLower();
        }
    } //Game loop
}