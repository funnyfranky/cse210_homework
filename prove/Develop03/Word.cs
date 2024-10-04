using System;

namespace Develop03;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetWord()
    {
        if (_isHidden)
        {
            string tempReturnVal = "";
            for (int n = 0; n < _word.Length; n++)
            {
                tempReturnVal = tempReturnVal + "_";
            }
            return tempReturnVal + " ";
        }
        else
        {
            return $"{_word} ";
        }
    }
}