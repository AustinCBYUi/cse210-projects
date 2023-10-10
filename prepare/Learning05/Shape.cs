using System.Drawing;
using System.Dynamic;
using System.Security.Claims;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }


    public virtual string GetColor()
    {
        return _color;
    }


    public abstract double GetArea();
}

