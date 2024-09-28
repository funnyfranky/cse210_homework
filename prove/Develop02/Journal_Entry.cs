using System;

namespace Develop02;

public class Journal_Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Journal_Entry(string date, string prompt, string journalText)
    {
        _date = date;
        this._promptText = prompt;
        this._entryText = journalText;
    }
    // Functions ex public void Display() {}
    public void Display()
    {
        Console.WriteLine($"(Date: {_date}) Prompt: {_promptText}\n{_entryText}");
    }
}