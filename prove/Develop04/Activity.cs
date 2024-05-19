using System;
using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = " ";
        _description = "";
        _duration = 0;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(_description);
        Console.WriteLine($"Welcome to the {_name} activity!!!!!");
        Console.Write("How long do you want it to run for? ");
        string activityDuration = Console.ReadLine();


        while (!int.TryParse(activityDuration, out _duration))
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a valid number for the duration.");
            Console.Write("How long do you want it to run for? ");
            activityDuration = Console.ReadLine();
        }
        _duration = int.Parse(activityDuration);

    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You just compleated {_duration} seconds in the {_name}!!");
        //Thread.Sleep(3000);//add animation
        ShowSpiner(5);

        Console.Clear();

    }

    public void ShowSpiner(int seconds)
    {
        List<string> spiner = new List<string>();
        spiner.Add("+");
        spiner.Add("x");
        spiner.Add("+");
        spiner.Add("x");
        spiner.Add("+");
        spiner.Add("x");
        spiner.Add("+");
        spiner.Add("x");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        do
        {
            foreach (string s in spiner)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        while (DateTime.Now < endTime);


    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;

        }



    }
}