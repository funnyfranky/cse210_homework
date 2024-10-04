using System;

namespace Develop03;

public class Reference(string arg1)
{
    private string _reference = arg1;

    public string GetReference()
    {
        return _reference;
    }
}
