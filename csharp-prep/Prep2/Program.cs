using System;

class Program
{
    static void Main(string[] args)
    {
        //Assign Grade string in the first place.
        string grade;

        //Prompt for user
        Console.Write("Hello, what is your grade percentage? ");
        //Capture user input in the form of a string.
        string gradePercUserInput = Console.ReadLine();
        //Convert gradePercUserInput to a float?
        //I guess if you had a 83.5, but considering how pointless that is I changed it back to int.
        int gradeConverted = int.Parse(gradePercUserInput);

        //A Condition
        if (gradeConverted >= 90)
        {
            if (gradeConverted >= 95)
            {
                grade = "A";
            }
            else
            {
                grade = "A-";
            }
        }

        //B Condition
        else if (gradeConverted >= 80)
        {
            if (gradeConverted >= 86)
            {
                grade = "B+";
            }
            else if (gradeConverted <= 84)
            {
                grade = "B-";
            }
            else //85%
            {
                grade = "B";
            }
        }

        //C Condition
        else if (gradeConverted >= 70)
        {
            if (gradeConverted >= 76)
            {
                grade = "C+";
            }
            else if (gradeConverted <= 74)
            {
                grade = "C-";
            }
            else //75%
            {
                grade = "C";
            }
        }

        //D Condition
        else if (gradeConverted >= 60)
        {
            if (gradeConverted >= 66)
            {
                grade = "D+";
            }
            else if (gradeConverted <= 64)
            {
                grade = "D-";
            }
            else //65%
            {
                grade = "D";
            }
        }

        //F condition
        //There is no F+, or F-
        else
        {
            grade = "F";
        }
        
        //another conditional to figure out if you passed the class or not.
        //If your grade percentage is anything greater than 70, you passed the class. Else you probably failed!
        if (gradeConverted >= 70)
        {
            Console.WriteLine($"Congratulations, you passed with a {grade}!");
        }
        else
        {
            Console.WriteLine($"You failed the class with a {grade}, but I know you can do better next time!");
        }
    }
}