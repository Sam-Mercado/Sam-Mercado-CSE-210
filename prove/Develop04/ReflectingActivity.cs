using System;
using System.Diagnostics;

class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = new List<string>{
            "----Think of a time when you stood up for someone else.----",
            "----Think of a time when you did something really difficult.----",
            "----Think of a time when you helped someone in need.----",
            "----Think of a time when you did something truly selfless.----"
        };
        //_prompts.Add("----Think of a time when you stood up for someone else.----");
        //_prompts.Add("----Think of a time when you did something really difficult.----");
        //_prompts.Add("----Think of a time when you helped someone in need.----");
        //_prompts.Add("----Think of a time when you did something truly selfless.----");

        _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        //_questions.Add("Why was this experience meaningful to you?");
        //_questions.Add("Have you ever done anything like this before?");
        //_questions.Add("How did you get started?");
        //_questions.Add("How did you feel when it was complete?");
        //_questions.Add("What made this time different than other times when you were not as successful?");
        //_questions.Add("What is your favorite thing about this experience?");
        //_questions.Add("What could you learn from this experience that applies to other situations?");
        //_questions.Add("What did you learn about yourself through this experience?");
        //_questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they relate with the experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DisplayQuestion();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rng = new Random();
        int index = rng.Next(_questions.Count);
        return _questions[index];
    }



    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.Write("When you have something in mind press \"enter\" to continue ");
        string enterToContinue = "1";


        do
        {
            ShowSpiner(5);
            Console.Write("\b");
            enterToContinue = Console.ReadLine();

        } while (string.IsNullOrEmpty(enterToContinue) != true);


    }

    public void DisplayQuestion()
    {
        int spinerTime = 7;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Clear();

        do
        {
            for (int i = _duration; i > 0; i--)
            {
                Console.Write(GetRandomQuestion());
                ShowSpiner(spinerTime);
                Console.WriteLine("");
                i = i - spinerTime;
            }

        } while (DateTime.Now <= endTime);

    }
}