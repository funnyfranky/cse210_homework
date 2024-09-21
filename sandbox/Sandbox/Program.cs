using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("Press enter to continue...");
        string input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine("Nice!");
        }
        else
        {
            Console.WriteLine($"You typed '{input}' before you hit enter. You're the worst.");
        }
    }
}