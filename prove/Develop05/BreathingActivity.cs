using System;

namespace Develop05;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }


    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DateTime finish = DateTime.Now.AddSeconds(GetDuration());
        do 
        {
        Console.WriteLine("Breathe in...");
        ShowSpinner(5);
        Console.WriteLine("Breathe out...");
        ShowSpinner(6);
        Console.WriteLine();
        } while (DateTime.Now < finish);

        DisplayEndingMessage();
    }
}
