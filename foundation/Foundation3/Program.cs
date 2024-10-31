using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = [];
        exerciseList.Add(new Running(DateOnly.FromDateTime(DateTime.Now),9,1));
        exerciseList.Add(new Swimming(new DateOnly(2024,09,10),40,15));
        exerciseList.Add(new Biking(new DateOnly(2024,10,29),60,12));

        foreach (Exercise r in exerciseList)
        {
            Console.WriteLine(r.GetDetails());
        }
        
    }
}