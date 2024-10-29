using System;

namespace Develop06;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal()
        {
        _amountComplete = 0;

        Console.Write("What is your goal?: ");
        SetName(Console.ReadLine());

        Console.Write("Describe the goal: ");
        SetDescription(Console.ReadLine());

        Console.Write("How many points is that goal worth?: ");
        SetPoints(int.Parse(Console.ReadLine()));

        Console.Write("How many times do you want to complete that goal?: ");
        SetTarget(int.Parse(Console.ReadLine()));

        Console.Write("How many points is the bonus for completing all times?: ");
        SetBonus(Console.ReadLine());

        }
    public ChecklistGoal(string name, string description, int points, int amountComplete, int target, int bonus) : base(name, description, points)
    {
        _amountComplete = amountComplete;
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountComplete(int num)
    {
        _amountComplete = num;
    }
    public int GetAmountComplete()
    {
        return _amountComplete;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public void SetTarget(string target)
    {
        _target = int.Parse(target);
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public void SetBonus(string bonus)
    {
        _bonus = int.Parse(bonus);
    }
    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent(GoalManager x)
    {
        _amountComplete += 1;
        if (_amountComplete == _target)
        {
            Console.WriteLine("Congrats! You finished this goal and got the bonus points!");
            x.AddToScore(GetBonus());
        }
    }

    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{GetType().ToString().Split(".")[1]}: {GetName()} - {GetDescription()} | {GetPoints()} points | {GetAmountComplete()} of {GetTarget()} (Bonus of {GetPoints()})";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetType()}||{GetName()}||{GetDescription()}||{GetPoints()}||{GetAmountComplete()}||{GetTarget()}||{GetBonus()}";
    }

}
