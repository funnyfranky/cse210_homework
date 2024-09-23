using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Jared Nakamua";
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "CEO";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "lowly Salesman";
        job2._startYear = 2022;
        job2._endYear = 2024;

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.Display();
    }
}