using System;

namespace Foundation3;

public abstract class Exercise
{
    private DateOnly _date;
    private int _minutesExercised;

    public Exercise(DateOnly date, int minsExercised)
    {
        _date = date;
        _minutesExercised = minsExercised;
    }


    

    public DateOnly GetDate()
    {
        return _date;
    }
    public void SetDate(DateOnly d)
    {
        _date = d;
    }
    public int GetMinutes()
    {
        return _minutesExercised;
    }
    public void SetMinutes(int m)
    {
        _minutesExercised = m;
    }

    public abstract string GetDetails();
    public abstract string GetSpeed();

    public abstract string GetPace();

}
