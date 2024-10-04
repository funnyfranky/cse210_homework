using System;

namespace Develop03;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = [];

    public Scripture(string refer, string scrip)
    {
        _reference = new Reference(refer);
        string[] splitScrip = scrip.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string value in splitScrip)
        {
            _scripture.Add(new Word(value));
        }
    }

    public void DisplayScripture()
    {
        Console.Write($"{_reference.GetReference()} ");
        foreach (Word scripture in _scripture)
        {
            Console.Write($"{scripture.GetWord()}");
        }
    }
    public void HideRandomWords(int numGone)
    {
        Random rng = new();
        int count = 0;
        do
        {

            int integer = rng.Next(0, _scripture.Count);
            if (!_scripture[integer].IsHidden())
            {
                count++;
                _scripture[integer].Hide();
                if (IsCompletelyHidden()) { break; }
            }
        } while (count < numGone);
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _scripture)
        {
            if (word.IsHidden()) { }
            else { return false; }
        }
        return true;
    }
    public void ShowAllWords()
    {
        foreach (Word word in _scripture)
        {
            word.Show();
        }
    }
}
