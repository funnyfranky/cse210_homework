using System;

namespace Develop02;

public class PromptGenerator
{
    private List<string> _prompts = ["Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?","What was the most challenging thing I faced today?","What did I learn about myself today?","What was the most beautiful thing I saw today?","What am I grateful for today?","What was the most surprising thing that happened to me today?","What was the most random thing that happened to me today?","What is one thing I accomplished today that I'm proud of?","What was the most thoughtful thing someone did for me today?","What was the most exciting thing I experienced today?","What was the most relaxing moment of my day?","What was the most inspiring thing I saw or heard today?","What was the most difficult decision I had to make today?","What was the most memorable conversation I had today?","What was the most delicious thing I ate today?","What was the most meaningful thing I learned today?"];
    public PromptGenerator() {}
    public string generatePrompt()
    {
        Random rnd = new();
        int random1 = rnd.Next(0,_prompts.Count);
        return _prompts[random1];
    }
}
