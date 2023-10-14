public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double len, double width, string color) : base(color)
    {
        _length = len;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}