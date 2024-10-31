using System;

namespace Foundation3;

public class Biking : Exercise
{
    private double _speed;
    public Biking(DateOnly date, int minsExercised, double speed) : base(date, minsExercised)
    {
        _speed = speed;
    }

    public override string GetDetails()
    {
        return $"{GetDate()} {GetType().ToString().Split('.')[1]} ({GetMinutes()} min)- Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}";
    }

    public string GetDistance()
    {
        return $"{GetCalcSpeed() / 60 * GetMinutes()} km";
    }
    private double GetCalcSpeed()
    {
        return _speed;
    }
    public override string GetSpeed()
    {
        return $"{GetCalcSpeed()} kph";
    }
    public override string GetPace()
    {
        return $"{60 / GetCalcSpeed()} min per km";
    }
}
