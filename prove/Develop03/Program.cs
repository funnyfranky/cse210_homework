using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1;
        Console.WriteLine("Which scripture would you like to memorize?: \n1. 1 Nephi 17:3\n2. Proverbs 3:5-6\n3. Alma 7:11-12\n4. Input your own!");
        int userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            scripture1 = new Scripture("1 Nephi 17:3", "And thus we see that the commandments of God must be fulfilled. And if it so be that the children of men keep the commandments of God he doth nourish them, and strengthen them, and provide means whereby they can accomplish the thing which he has commanded them; wherefore, he did provide means for us while we did sojourn in the wilderness.");
        }
        else if (userChoice == 2)
        {
            scripture1 = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him and He shall direct thy paths.");
        }
        else if (userChoice == 3)
        {
            scripture1 = new Scripture("Alma 7:11-12", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        }
        else if (userChoice == 4)
        {
            Console.WriteLine("Input the whole reference here, like this: Book 1:3-7");
            string reference1 = Console.ReadLine();
            Console.WriteLine("Input the whole verse here, like this: And thus it came to pass...");
            string verseText1 = Console.ReadLine();
            scripture1 = new Scripture(reference1,verseText1);
        }
        else
        {
            scripture1 = new Scripture("Error:", "couldn't find that choice. Try running the program again.");
        }
        // 1 Nephi 17:3 And thus we see that the commandments of God must be fulfilled. And if it so be that the children of men keep the commandments of God he doth nourish them, and strengthen them, and provide means whereby they can accomplish the thing which he has commanded them; wherefore, he did provide means for us while we did sojourn in the wilderness.
        // Proverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him and He shall direct thy paths.
        // Alma 7:11-12 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.

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

// This code goes above the project requirements. I built in the availability
// to choose from three predefined scriptures, or easily add your own and
// memorize it.