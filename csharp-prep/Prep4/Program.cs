using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
//This ^^ is a requirement for lists.

/*
* Really enjoyed this one, would be simpler to use functions looking back on this after learning functions!
*/

class Program
{
    static void Main(string[] args)
    {
        //Answer is set to -1 by default, doesn't work if set to 0 obviously..
        int answer = -1;
        //Create new list named userNumbers.
        List<int> userNumbers = new List<int>();

        //Direction for user.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //While loop to add all items to list.
        while (answer != 0)
        {
            //Whatever user types.
            int userInput = int.Parse(Console.ReadLine());
            //If userInput is not equal to zero..
            if (userInput != 0)
            {
                //.. add the number to the userInput list.
                userNumbers.Add(userInput);
            }

            //If user types 0 it will terminate the while loop.
            if (userInput == 0)
            {
                //start the sum at 0.
                int sum = 0;
                //If you want a float, you must divide by a float :/
                float numOfNumbers = userNumbers.Count;
                //The max I saw in use by the demonstration code, and my original method wouldn't have worked right.
                int max = userNumbers[0];

                //Loop through each item in userNumbers.
                foreach (int item in userNumbers)
                {
                    sum += item;
                    //This is from the example, I would have had it wrong with my method.
                    if (item > max)
                    {
                        max = item;
                    }
                }
                float avg = sum / numOfNumbers;
                Console.WriteLine($"The sum of all numbers was: {sum}.");
                Console.WriteLine($"The average was: {avg}.");
                Console.WriteLine($"Largest number was: {max}.");
                //Sort the list! Tried to use this with a new list named sortedlist = userNumbers.Sort() but now
                //Looking back at that, seems sorta counterintuitive versus literally just calling it on the list..
                userNumbers.Sort();
                Console.WriteLine($"The sorted list is: {userNumbers}.");
            }
        }
    }
}