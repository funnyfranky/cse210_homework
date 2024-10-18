using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Assignment yeet = new("James", "Multiplication");
        Console.WriteLine(yeet.GetSummary());

        MathAssignment yeet2 = new("Alex","Science","7.3","8-19");
        Console.WriteLine($"{yeet2.GetSummary()}\n{yeet2.GetHomeworkList()}");

        WritingAssignment yeet3 = new("Fred","European History","The Causes of World War II");
        Console.WriteLine($"{yeet3.GetSummary()}\n{yeet3.GetWritingInformation()}");

    }
}