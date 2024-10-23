using System;

namespace learning06;

public class Circle : Shape
{
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public float GetRadius()
    {
        return _radius;
    }
    public void SetRadius(float radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(GetRadius(), 2);
    }
}
