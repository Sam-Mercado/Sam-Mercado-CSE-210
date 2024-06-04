using System;


public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string date, string time, string street, string city, string state, string country, string speaker, int capacity)
    : base(title, date, time, street, city, state, country)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
        _description = ShortDescription();

    }

    public void FullDetails()
    {

        Console.WriteLine($"{StandardDetails()} \n Speaker: {_speaker} \n Capacity: {_capacity} people ");

    }

    public string ShortDescription()
    {
        return "This types of meetings have a speaker and have a limited capacity.";
    }
}