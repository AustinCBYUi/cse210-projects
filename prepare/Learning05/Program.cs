using System;

class Program
{
    static void Main(string[] args)
    {
        Square newSquare = new Square(3, "red");
        Console.WriteLine(newSquare);
        Rectangle newRect = new Rectangle(3, 5, "green");
        Console.WriteLine(newRect);
    }
}