using System;

namespace Develop02;

public class JournalEntry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public JournalEntry(string date, string prompt, string journalText)
    {
        _date = date;
        _promptText = prompt;
        _entryText = journalText;
    }
    // Functions ex public void Display() {}
    public void Display()
    {
        Console.WriteLine($"(Date: {_date}) Prompt: {_promptText}\n{_entryText}");
    }
}