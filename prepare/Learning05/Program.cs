using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        //Instantiate a new shape from the different shapes classes (square rectangle or circle)
        Square newSquare = new Square(3, "Red");
        //Then add to the list, repeats for the following shapes.
        shapes.Add(newSquare);
        Rectangle newRect = new Rectangle(3, 5, "Green");
        shapes.Add(newRect);
        Circle newCircle = new Circle(5, "Purple");
        shapes.Add(newCircle);

        //Loop through each shape in the shapes list.
        foreach (Shape shape in shapes)
        {
            //Write the Shape name, the area with GetArea, and color with GetColor.
            Console.WriteLine($"{shape} - Area: {shape.GetArea()} | Color: {shape.GetColor()}");
        }
    }
}