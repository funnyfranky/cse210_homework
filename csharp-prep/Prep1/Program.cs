using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string FName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string LName = Console.ReadLine();

        Console.Write($"Your name is {LName}, {FName} {LName}.");
    }
}