using System;
using System.IO;

namespace Develop02;

public class Journal
{
    public List<Journal_Entry> entryList = [];
    public string dateCreated;
    public string dateLastEntry;

    public Journal()
    {

    }

    // Functions ex public void Display() {}
    public void NewJournalEntry(string date, string prompt, string journalText)
    {
        // Create a Journal_Entry object with date, prompt and input text
        entryList.Add(new(date, prompt, journalText));

    }
    public void DisplayAllEntries()
    {
        foreach (Journal_Entry entry in entryList)
        {
            entry.Display();
        }
    }
    public void ExportToFile(string fileName)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new(fileName + ".txt"))
        {
            foreach (Journal_Entry jEntry in entryList)
            {
                outputFile.WriteLine($"{jEntry._date}|||{jEntry._promptText}|||{jEntry._entryText}");
            }
        }
        Console.WriteLine("Successfully saved to file!");
    }
    public void ImportFromFile(string fileName)
    {
        Console.WriteLine("Importing from file...");
        using (StreamReader importFile = new(fileName + ".txt"))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName + ".txt");
            foreach (string line in lines)
            {
                string[] splitLine = line.Split("|||");
                // NewJournalEntry(DateTime.Parse(splitLine[0]),splitLine[1],splitLine[2]);
                NewJournalEntry(splitLine[0],splitLine[1],splitLine[2]);
            }
        }
        Console.WriteLine("Successfully imported from file!");
    }
}