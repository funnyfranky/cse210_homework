using System;

namespace Develop06;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal()
    {
        _isComplete = false;

        Console.Write("What is your goal?: ");
        SetName(Console.ReadLine());
        Console.Write("Describe the goal: ");
        SetDescription(Console.ReadLine());
        Console.Write("How many points is that goal worth?: ");
        SetPoints(Console.ReadLine());

    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent(GoalManager x)
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // Name, Description, Points, CompleteStatus
        return $"{GetType()}||{GetName()}||{GetDescription()}||{GetPoints()}||{IsComplete()}";
    }


}
