using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        int keepGoing = -1;
        while (keepGoing == -1)
        {
            // MENU TO CHOOSE PROGRAM
            Console.Write("Menu Options:\n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit\nSelect a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                new BreathingActivity().Run();
            }
            else if (userChoice == 2)
            {
                new ReflectingActivity().Run();
            }
            else if (userChoice == 3)
            {
                new ListingActivity().Run();
            }
            else if (userChoice == 4)
            { Console.WriteLine(); keepGoing = 0; }
            else
            {
                Console.WriteLine($"That didn't work. Good try though: {userChoice}"); 
            }
        }
    }
}