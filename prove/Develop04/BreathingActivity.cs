using System;
using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {

    }

    public void Run()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        DisplayStartingMessage();
        //After the starting message, the user is shown a series of messages 
        //alternating between "Breathe in..." and "Breathe out..."
        //How to?: 
        //time = input saying, set the time 
        // timeTipe = input is your time in Hours, minutes, seconds?
        //while (timeTipe.lower != "minutes"|| "hours"|| "seconds") input is your time in Hours, minutes, seconds?
        // if (timeTipe.Lowercase == "hours")set time = time * 3600
        // if (timeTipe.lower == "minutes") set time = time * 60
        // else 
        //Get ready ...(animtion)
        Console.WriteLine("");
        Console.Write("Get Ready");
        ShowSpiner(5);
        Console.WriteLine("");
        //Stop the app for 3 seconds
        Thread.Sleep(3000);
        //write a while (DateTime.Now < endTime)
        //write a line with the text breath in + showCountDown(every 3 seconds), 
        //after the 3 seconds using the Thread.Sleep() write text breath out + showCountDown(every 3 seconds)
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int countDown = 5;
        do
        {
            for (int i = _duration; i > 0; i--)
            {
                Console.Write("Breath in....");
                ShowCountDown(countDown);
                Console.WriteLine("");
                //Thread.Sleep(3000);


                Console.Write("Breath out....");
                ShowCountDown(countDown);
                Console.WriteLine("");
                //Thread.Sleep(3000);
                i = i - countDown * 2;

            }

        } while (DateTime.Now < endTime);

        DisplayEndingMessage();

    }
}