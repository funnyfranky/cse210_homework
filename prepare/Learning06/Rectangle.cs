using System;

namespace learning06;

public class Rectangle : Shape
{
    private float _lSide;
    private float _wSide;

    public Rectangle(string color, float lSide, float wSide) : base(color)
    {
        _lSide = lSide;
        _wSide = wSide;
    }

    public float GetLSide()
    {
        return _lSide;
    }
    public void SetLSide(float lSide)
    {
        _lSide = lSide;
    }
    public float GetWSide()
    {
        return _wSide;
    }
    public void SetWSide(float wSide)
    {
        _wSide = wSide;
    }

    public override double GetArea()
    {
        return GetLSide() * GetWSide();
    }
}
