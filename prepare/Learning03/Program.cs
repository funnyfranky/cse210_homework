using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new();
        Fraction fraction2 = new(6);
        Fraction fraction3 = new(6,7);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}