using System;

namespace Develop06;

public class EternalGoal : Goal
{
    public EternalGoal()
    {
        Console.Write("What is your goal?: ");
        SetName(Console.ReadLine());
        Console.Write("Describe the goal: ");
        SetDescription(Console.ReadLine());
        Console.Write("How many points is that goal worth?: ");
        SetPoints(int.Parse(Console.ReadLine()));

    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent(GoalManager x)
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{GetType()}||{GetName()}||{GetDescription()}||{GetPoints()}";
    }

}
