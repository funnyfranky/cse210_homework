using System;
using System.ComponentModel.DataAnnotations;

namespace Develop05;

public class ReflectingActivity : Activity
{
    int WAIT_TIME_BETWEEN_QUESTIONS_FOR_REFLECTING_ACTIVITY = 15;
    int GENERAL_PAUSE_LENGTH = 3;

    List<string> _prompts = ["Describe a moment when you felt truly proud of yourself.", "Recall a time you overcame a significant obstacle.", "Think of an event that changed your perspective on life.", "Think about a memory that always makes you smile.", "What was a pivotal moment in your personal growth?", "Remember a time when you helped someone in need.", "Reflect on an experience that taught you an important lesson.", "Describe a situation where you had to make a tough decision.", "Think of a moment when you felt completely at peace.", "What’s an instance where you surprised yourself with your abilities?", "Think of a time when you did something really difficult."];
    List<string> _questions = ["How did this experience make you feel in the moment?", "What were the most memorable parts of this experience?", "What thoughts went through your mind during this time?", "How did you overcome any challenges you faced?", "What did you learn about yourself from this experience?", "In what ways has this experience shaped who you are today?", "How would you approach a similar situation in the future?", "What positive outcomes came from this experience?", "How has this experience influenced your relationships with others?", "What advice would you give to someone going through a similar experience?"];

    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(GENERAL_PAUSE_LENGTH);

        Console.WriteLine($"Consider the following prompt:\n\n --- {GetPrompt()} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowCountDown(GENERAL_PAUSE_LENGTH);


        DateTime finish = DateTime.Now.AddSeconds(GetDuration());
        do 
        {
        Console.WriteLine($" > {GetQuestion()}");
        ShowSpinner(WAIT_TIME_BETWEEN_QUESTIONS_FOR_REFLECTING_ACTIVITY);
        } while (DateTime.Now < finish);

        DisplayEndingMessage();
    }

    private string GetPrompt()
    {
        List<string> stringList = [ ];
        
        Random rnd = new();
        return _prompts[rnd.Next(0,_prompts.Count)];
    }
    private string GetQuestion()
    {
        List<string> stringList = [];

        Random rnd = new();
        return _questions[rnd.Next(0,_questions.Count)];
    }
}


    