using System;

namespace Develop03;

public class Reference
{
    private string _reference;

    public Reference()
    {
        _reference = "Proverbs 3:5-6";
    }
    public Reference(string arg1)
    {
        _reference = arg1;
    }

    public string GetReference()
    {
        return _reference;
    }
}
