using System;

namespace Develop06;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int amountComplete, int target, int bonus) : base(name, description, points)
    {
        _amountComplete = amountComplete;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }

}
