using System;
using System.Diagnostics;

class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string>{
           " ----Who are people that you appreciate? ----",
            " ----What are personal strengths of yours? ----",
            " ----Who are people that you have helped this week? ----",
            " ----When have you felt the Holy Ghost this month? ----",
            " ----Who are some of your personal heroes? ----"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

    }

    public List<string> GetListFromUser()
    {
        //user need to be able to write a list while the time is running. 
        //While (time runing) Console.ReadLine() and print what is stored in the variable and put it in a list 

        Console.Write("You may begin in....");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> listFromUser = new List<string>();
        //string userInput = Console.ReadLine();
        //do
        //{
        //    userInput = Console.ReadLine();
        // listFromUser = new List<string>();

        //    if (!string.IsNullOrEmpty(userInput))
        //   {
        //        listFromUser.Add(userInput);
        //        _count += userInput.Split(' ').Length;
        //    }
        //foreach (string i in listFromUser)
        //{
        //Console.Clear();
        //    listFromUser.Add(userInput);
        //    Console.WriteLine(i);
        //    _count += 1;
        //}
        //_count = listFromUser.Count;

        //} while (DateTime.Now < endTime);
        while (DateTime.Now < endTime)
        {

            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                listFromUser.Add(userInput);
                _count += userInput.Split(' ').Length;
            }
        }

        Console.WriteLine($"You listed {_count} words");
        Thread.Sleep(3000);

        return listFromUser;


    }
}