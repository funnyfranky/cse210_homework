using System;
using System.ComponentModel.DataAnnotations;

namespace Foundation1;

public class Video
{
    private string _title = "Title N/A";
    private string _author = "Author N/A";
    private int _seconds = -1;
    private List<Comment> _comments = [];

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }
    public void AddComment(string user, string text)
    {
        _comments.Add(new Comment(user, text));
    }
    public int GetNumComments()
    {
        return _comments.Count;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}\nposted by {_author}\n{FormatTime()}\nComment Count: {GetNumComments()}\n");
        foreach (Comment c in _comments)
        {
            c.Display();
            Console.WriteLine();
        }
        Console.WriteLine("\n\n\n");
    }
    private string FormatTime()
    {
        // int minutes = _seconds / 60;
        // int seconds = _seconds % 60;
        return $"{_seconds / 60}:{_seconds % 60}";
    }
}