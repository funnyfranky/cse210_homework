using System;

namespace Learning03;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() 
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    private double GetTop()
    {
        return _top;
    }
    private void SetTop(int top) 
    {
        _top = top;
    }
    private double GetBottom()
    {
        return _bottom;
    }
    private void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{GetTop()}/{GetBottom()}";
    }
    public double GetDecimalValue()
    {
        return GetTop() / GetBottom();
    }
}
