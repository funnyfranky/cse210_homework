using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        // Scripture scripture1 = new("Some Scripture", "Jesus Wept.");
        Scripture scripture1 = new("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him and He shall direct thy paths.");

        Console.Clear();
        scripture1.DisplayScripture();
        do
        {
            Console.Write("\nPress enter to erase a few more words. Type \"quit\" to quit: ");
            if (Console.ReadLine() == "quit") { break; }

            scripture1.HideRandomWords(3);
            Console.Clear();

            scripture1.DisplayScripture();

        } while (!scripture1.IsCompletelyHidden());

        Console.WriteLine("\nPress enter to show the whole verse!");
        Console.ReadLine();

        Console.Clear();
        scripture1.ShowAllWords();
        scripture1.DisplayScripture();
        Console.WriteLine("\n\nThanks for playing!");
    }
}