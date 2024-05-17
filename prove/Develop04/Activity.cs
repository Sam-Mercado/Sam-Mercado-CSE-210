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
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a Choice from the menu \"number only\"");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You just compleated {_duration} in the {_name}!!");
        Thread.Sleep(3000);//add animation
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
                Thread.Sleep(800);
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

        }



    }
}