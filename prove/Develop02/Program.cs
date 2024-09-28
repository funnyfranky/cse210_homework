using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Journal workingJournal = new();
        PromptGenerator getPrompt = new();

        int userChoice = -1;
        do
        {
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) // Write option
            {
                // Display a prompt
                string prompt = getPrompt.GeneratePrompt();
                Console.WriteLine(prompt);

                // Take in input and put in a variable
                workingJournal.NewJournalEntry(DateTime.Now.ToString("yyyy MM dd"), prompt, Console.ReadLine());
            }
            else if (userChoice == 2) // Display option
            {
                workingJournal.DisplayAllEntries();
            }
            else if (userChoice == 3) // Load option
            {
                Console.Write("What file do you want to import? Ex. \"myFile\": ");
                string importFileName = Console.ReadLine();
                workingJournal.ImportFromFile(importFileName);
            }
            else if (userChoice == 4) // Save Option
            {
                Console.Write("What do you want the file to be called? Ex. \"myFile\": ");
                string exportFileName = Console.ReadLine();
                workingJournal.ExportToFile(exportFileName);
            }
            else if (userChoice == 5) // Quit Option
            {
                Console.WriteLine("Are you sure you would like to quit? Y/N: ");
                if (Console.ReadLine() == "Y") { userChoice = -1; }
            }
            else
            {
                Console.WriteLine($"Sorry, {userChoice} isn't implemented yet. Please enter another number!\n\n");
                userChoice = 0; // implements safe quitting only
            }
        } while (userChoice != -1);
    }
}

// I made the choices function so that the only way to quit the program is to choose quit option and then type an uppercase "Y" to more fully guarantee safe quitting. I also made it so there is no need to type a file extension as I automatically append ".txt" on the end of the chosen file name during both import and export to a file.