using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Business Developer";
        job1._company = "XpressRun";
        job1._startYear = 2014;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "UX UI Designer";
        job2._company = "Google";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "Software Engineer";
        job3._company = "Meta";
        job3._startYear = 2021;
        job3._endYear = 2024;



        Resume resume = new Resume();
        resume._name = "Samuel Mercado";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        resume.Display();

    }
}



