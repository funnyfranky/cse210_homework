using System;

namespace Foundation3;

public class Running : Exercise
{
    private double _distance;

    public Running(DateOnly date, int minsExercised, double distance) : base(date, minsExercised)
    {
        _distance = distance;
    }
    public override string GetDetails()
    {
        return $"{GetDate()} {GetType().ToString().Split('.')[1]} ({GetMinutes()} min)- Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}";
    }
    public double GetCalcDistance()
    {
        return _distance;
    }
    public string GetDistance()
    {
        return $"{GetCalcDistance()} km";
    }
    public void SetDistance(double d)
    {
        _distance = d;
    }

    // Speed (mph or kph) = (distance / minutes) * 60
    public double GetCalcSpeed()
    {
        return Math.Round(_distance / GetMinutes() * 60,2);
    }
    public override string GetSpeed()
    {
        return $"{GetCalcSpeed()} kph";
    }

    // Pace (min per mile or min per km)= minutes / distance
    public double GetCalcPace()
    {
        return Math.Round(GetMinutes() / GetCalcDistance(),2);
    }
    public override string GetPace()
    {
        return $"{GetCalcPace()} min per km";
    }

}
