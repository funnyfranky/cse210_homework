using System;
using System.Security.Cryptography.X509Certificates;

namespace learning06;

public class Shape
{
    private string _color;
    // public Shape() { }
    public Shape(string color) { _color = color; }

    public string GetColor() { return _color; }
    public void SetColor(string color) { _color = color; }
    public virtual double GetArea()
    {
        return -1;
    }
}
