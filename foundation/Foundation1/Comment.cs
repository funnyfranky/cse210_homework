using System;
using System.ComponentModel.DataAnnotations;

namespace Foundation1;

public class Comment
{
    private string _commentUser = "Unknown Author";
    private string _commentText = "No text to display";

    public Comment() { }
    public Comment(string user, string text)
    {
        _commentUser = user;
        _commentText = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_commentUser}:\n{_commentText}");
    }

}