using System;

namespace Develop05;

public class ListingActivity : Activity
{
    int GENERAL_PAUSE_LENGTH = 5;

    List<string> _prompts = ["Example prompt for listing activity"
                            ,"What are three things you're grateful for this week?"
                            ,"Who are the people that made you smile recently and how?"
                            ,"What is something you achieved this year that you're proud of?"
                            ,"Which hobbies or activities have brought you joy lately?"
                            ,"What unexpected kindness have you experienced recently?"
                            ,"How has nature or the outdoors positively impacted you this month?"
                            ,"What talents or skills have you discovered or honed recently?"
                            ,"Which moments of laughter can you recall from the past few weeks?"
                            ,"What books, movies, or shows have inspired you recently?"
                            ,"How have your relationships positively influenced you this year?"];


    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    public void Run()
    {
        int count = 0;
        Random rnd = new();
        DisplayStartingMessage();
        Console.WriteLine($"List as many responses as you can to the following prompt:\n ---{_prompts[rnd.Next(0,_prompts.Count)]}---");
        ShowCountDown(GENERAL_PAUSE_LENGTH);
        DateTime finish = DateTime.Now.AddSeconds(GetDuration());
        do 
        {
            Console.Write("> ");
            Console.ReadLine();
            count ++;
        } while (DateTime.Now < finish);

        Console.WriteLine($"You input {count} responses!");
        ShowSpinner(GENERAL_PAUSE_LENGTH);
        DisplayEndingMessage();
    }
}
