using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment newMainAssignment = new Assignment("Austin Campbell", "Math");
        MathAssignment newMathAssignment = new MathAssignment("Austin Campbell", "Math", "10-2", "10-40");
        string math = newMathAssignment.GetSummary() + newMathAssignment.GetHomeWorkProblems();

        Console.WriteLine(math);

        WritingAssignment newWritingAssignment = new WritingAssignment("Austin C", "Geomagnetic Storms",
        "The Effects of Geomagnetic Storms on Earth.");
        string writing = newWritingAssignment.GetSummary() + newWritingAssignment.GetWritingInformation();
        Console.WriteLine(writing);

    }
}