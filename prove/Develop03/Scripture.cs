using System;

namespace Develop03;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = [];

    // public Scripture() 
    // {
    //     // _reference = new Reference("Proverbs 3:5-6");
    //     // _scripture = [new Word("Trust"), new Word("in"), new Word("the"), new Word("Lord")];
    // }
    public Scripture(string refer, string scrip)
    {
        _reference = new Reference(refer);
        string[] splitScrip = scrip.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string value in splitScrip)
        {
            _scripture.Add(new Word(value));
        }

        // _reference = "Proverbs 3:5-6";
        // _scripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding, in all thy ways acknowledge Him and He shall direct thy paths.";
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
        Random rng = new Random();
        int count = 0;
        do {
            
            int integer = rng.Next(0,_scripture.Count);
            if (!_scripture[integer].IsHidden())
            {
                count ++;
                _scripture[integer].Hide();
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
    // public void DisplayWithBlanks(List<int> list)
    // {

    // }
    // public int GetWordCount()
    // {
    //     string[] words = _scripture.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    //     return words.Length;
    // }
}
