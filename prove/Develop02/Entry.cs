using System;
using System.Collections.Generic; //Include for using List<>

public class Entry
{
    //Fields to store the date, prompt, and response of journal entry
    public string _date;
    public string _prompt;
    public string _response;

    //Generates the current dae in short format and assigns it to _date
    public void GenerateDate()
    {
        DateTime timeNow = DateTime.Now;//Get current system time
        _date = timeNow.ToShortDateString();//Convert to short date string 
    }

    //Randomly selects a prompt from a list and outputs it
    public void ListGeneration()
    {
        //List of questions for the journal entry
        List<string> prompts = new List<string>()
        {
         "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"

        };

        Random random = new Random(); //iniciate a random number generator
        int randomindexNum = random.Next(prompts.Count);//Get a random index
        _prompt = prompts[randomindexNum];//Assign th random promp
        Console.WriteLine(_prompt);//Output the prompt to the console
    }

    //Captures the user's response to the prompt via the console
    public void ResponceGeneration()
    {
        Console.Write("-->");// Prompt the user for input
        _response = Console.ReadLine();//Read the user's input from the conosle 
    }

}