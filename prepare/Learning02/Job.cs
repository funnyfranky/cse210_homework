public class Job
{
    public string _jobTitle = "default";
    public string _company = "default";
    public int _startYear = -1;
    public int _endYear = -1;

    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{this._jobTitle} ({this._company}) {this._startYear}-{this._endYear}");
    }

}