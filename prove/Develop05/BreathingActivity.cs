using System;

namespace Develop05;

public class BreathingActivity : Activity
{
    int SECONDS_BREATHE_IN_LENGTH = 5;
    int SECONDS_BREATHE_OUT_LENGTH = 6;

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
        ShowSpinner(SECONDS_BREATHE_IN_LENGTH);
        Console.WriteLine("Breathe out...");
        ShowSpinner(SECONDS_BREATHE_OUT_LENGTH);
        Console.WriteLine();
        } while (DateTime.Now < finish);

        DisplayEndingMessage();
    }
}
