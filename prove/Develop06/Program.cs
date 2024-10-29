using System;

namespace Develop06;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();
        manager.Start();
    }
}

// To exceed core requirements I added helper functions to do things like parse strings and return -1 if it's not a valid string, one that adds an int to the score in goal manager to aid with bonus points, one that's called ExOrNah that helps when I print out the list of goals by returning the correct string based on if it's completed or not. They help simplify my code a little bit.