using System;
using System.IO;

namespace Develop02;

public class Journal
{
    public List<JournalEntry> _entryList = [];
    // public string _dateCreated;
    // public string _dateLastEntry;

    public Journal()
    {

    }

    // Functions ex public void Display() {}
    public void NewJournalEntry(string date, string prompt, string journalText)
    {
        // Create a JournalEntry object with date, prompt and input text
        _entryList.Add(new(date, prompt, journalText));

    }
    public void DisplayAllEntries()
    {
        foreach (JournalEntry entry in _entryList)
        {
            entry.Display();
        }
    }
    public void ExportToFile(string fileName)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new(fileName + ".txt"))
        {
            foreach (JournalEntry jEntry in _entryList)
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