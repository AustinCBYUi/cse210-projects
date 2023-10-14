public class Circle : Shape
{
    private double _radius;
    private double _PI = 3.14159;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double stepOne = Math.Pow(_radius, 2);
        return _PI * stepOne;
    }
}