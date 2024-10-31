using System;

namespace Foundation3;

public class Swimming : Exercise
{
    private int _numLaps;

    public Swimming(DateOnly date, int minsExercised, int laps) : base(date, minsExercised)
    {
        _numLaps = laps;
    }

    public override string GetDetails()
    {
        return $"{GetDate()} {GetType().ToString().Split('.')[1]} ({GetMinutes()} mins)- Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}";
    }



// Distance (km) = swimming laps * 50 / 1000
    private double GetKmCalcDistance()
    {
        return _numLaps * 0.05;
    }
    private string GetDistance()
    {
        return $"{GetKmCalcDistance()} km";
    }
// NOT IMPLEMENTED Distance (miles) = swimming laps * 50 / 1000 * 0.62 NOT IMPLEMENTED

// Speed (mph or kph) = (distance / minutes) * 60
    public double GetCalqSpeed()
    {
        return Math.Round(GetKmCalcDistance() / GetMinutes() * 60,2);
    }
    public override string GetSpeed()
    {
        return $"{GetCalqSpeed()} kph";
    }
    private double GetCalcPace()
    {
        return Math.Round(GetMinutes() / GetKmCalcDistance(),2);
    }
    public override string GetPace()
    {
        return $"{GetCalcPace()} min per km";
    }

}
