using System;

public class Swimming : Activity
{

    protected double _numberOfLaps;
    // protected double distance;
    // protected double speed;
    // protected double pace;



    public Swimming(int lenght, int year, int month, int day, double numberOfLaps) : base(lenght, year, month, day)
    {
        _activity = "Swimming";
        _lenght = lenght;
        _numberOfLaps = numberOfLaps;
        // distance = GetDistance();
        // speed = GetSpeed();
        // pace = GetPace();
    }


    public override double GetDistance()
    {
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62
        double distance = _numberOfLaps * 50.0 / 1000.0 * 0.62;
        //double distance = _numberOfLaps * 50 / 1000 * 0.62;
        return distance;
    }
    //Speed (mph or kph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        double speed = GetDistance() / _lenght * 60;
        return speed;
    }

    //Pace (min per mile or min per km)= minutes / distance
    public override double GetPace()
    {
        double pace = GetSpeed() / GetDistance();
        return pace;
    }


    //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

    public override void GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date} {_activity}({_lenght} min) - Number of Laps {_numberOfLaps}- Distance {Math.Round(GetDistance(), 2)} mph, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile\n");
    }







}