using System;

namespace Learning05;

public class Assignment(string name, string topic)
{
    private string _studentName = name;
    private string _topic = topic;

    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
