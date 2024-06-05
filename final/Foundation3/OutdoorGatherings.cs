using System;

public class OutdoorGatherings : Event
{

    private string _weather;
    public OutdoorGatherings(string title, string date, string time, string street, string city, string state, string country)
    : base(title, date, time, street, city, state, country)
    {
        _type = "Outdoors";
        _description = "do not have a limit on attendees, but need to track the weather forecast.";
        _weather = "24˚C - Clear";



    }
    public void FullDetails()
    {
        Console.WriteLine("------------------------------------------------------");

        Console.WriteLine($"\n{StandardDetails()} \n Weather Forecast {_weather} ");

    }
}