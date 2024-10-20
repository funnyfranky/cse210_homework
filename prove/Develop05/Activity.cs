using System;

namespace Develop05;

public class Activity()
{
    private string _name;
    private string _description;
    private int _duration;
    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {_name}!\n\n{_description}\n\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.Clear();

        Console.WriteLine($"Get ready...");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!\n\nYou have completed {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        // int placeholders = 0;
        // while (seconds > 10)
        // {
        //     placeholders++;
        //     seconds /= 10;
        // }
        int x = seconds; 
        Console.Write("\\");
        while (x > 0)
        {
            UpdateText(4,$"/{x,3}");
            
            Thread.Sleep(500);

            UpdateText(4,$"\\{x,3}");
            
            Thread.Sleep(500);
            x--;
        }
    UpdateText(4, "\n");
    }
    public void ShowCountDown(int seconds)
    {
        int x = seconds;
        Console.Write($"You may begin in: {seconds, 3}");
        while (x > 0)
        {
            UpdateText(3,$"{x,3}");
            
            Thread.Sleep(500);

            UpdateText(3,$"{x,3}");
            
            Thread.Sleep(500);
            x--;
        }
    UpdateText(4, "\n");
    }
    public int GetDuration()
    {
        return _duration;
    }

    // public void Rewriteable(int chars)
    // {
    //     Console.Write(new string('\b', chars));
    //     Console.Write(new string(' ', chars));
    //     Console.Write(new string('\b', chars));
    // }
    public void UpdateText(int previousLength, string write)
    {
        // Erase previous text
        for (int i = 0; i < previousLength; i++)
        {
            Console.Write("\b \b");
        }

        // Write new text
        Console.Write(write);
    }    
    protected void SetName(string name)
    {
        _name = name;
    }
    protected void SetDescription(string description)
    {
        _description = description;
    }
    protected void SetDuration(int duration)
    {
        _duration = duration;
    }
}
