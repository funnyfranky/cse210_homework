using System;

namespace Develop06;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public void SetName(string name)
    {
        _shortName = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string desc)
    {
        _description = desc;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetPoints(string points)
    {
        _points = int.Parse(points);
    }

    public abstract void RecordEvent(GoalManager x);
    public abstract bool IsComplete();
    public virtual string GetDetailsString() { return $"{GetType().ToString().Split(".")[1]}: {GetName()} - {GetDescription()} | {GetPoints()} points"; }
    public abstract string GetStringRepresentation();
    public string ExOrNah()
    {
        if (IsComplete()) { return "X"; }
        else              { return " "; }
    }
}
