public class Resume
{
    public string _name = "no name entered";
    public List<Job> _jobList = new List<Job>();

    public Resume()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job i in _jobList)
        {
            i.Display();
        }
    }
}