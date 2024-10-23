using System;
using System.Reflection.Metadata.Ecma335;
using learning06;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        shapes.Add(new Square("Blue",4f));
        shapes.Add(new Square("White",6f));
        shapes.Add(new Rectangle("Green",6.7f,4.2f));
        shapes.Add(new Circle("Yellow",3f));

        foreach (Shape sha in shapes)
        {
            Console.WriteLine($"{sha.GetColor()}, {sha.GetArea()}");
        }
    }
}