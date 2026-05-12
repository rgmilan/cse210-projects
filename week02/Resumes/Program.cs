using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Construction Manager";
        job1._company = "Kele Built";
        job1._startYear = "2017";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Construction Manager";
        job2._company = "Delectable Ventures Inc";
        job2._startYear = "2022";
        job2._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "Argy Milan";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}