using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>();
        int input = -1;
        // DELETE ME Tester for loop
        // for (int i = 0; i < 5; i++)
        Console.WriteLine("Input an integer to add it to the list. Enter 0 to end. ");
        while (input != 0)
        {
            Console.Write("Enter number (or 0 to finish): ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                integers.Add(input);
            }
        }

        int sum = 0;
        float avg;
        int max = integers[0];
        
        foreach (int num in integers)
        {
            sum+=num;
            if (num > max)
            {
                max = num;
            }
            // Console.WriteLine($"{num} is in the list");
        }

        avg = (float)sum / (float)integers.Count();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}