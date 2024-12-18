using System;

namespace Learning05;

public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string txtbkSection, string problems) : base(name, topic)
    {
        _textbookSection = txtbkSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
