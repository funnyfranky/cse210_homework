using System;
using System.ComponentModel.DataAnnotations;

namespace Foundation1;

public class Comment
{
    private string _comment_user = "Unknown Author";
    private string _comment_text = "No text to display";

    public Comment() { }
    public Comment(string user, string text)
    {
        _comment_user = user;
        _comment_text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_comment_user}:\n{_comment_text}");
    }

}