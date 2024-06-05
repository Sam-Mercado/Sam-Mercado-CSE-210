using System;

public class Cycling : Activity
{
    protected double _speed;

    public Cycling(int lenght, int year, int month, int day, double speed) : base(lenght, year, month, day)
    {
        _activity = "Cyclin";
        _speed = speed;
    }


    public override double GetDistance()
    {
        double distance = _lenght / GetPace();
        return distance;
    }


    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    public override void GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date} {_activity}({_lenght} min) - Distance {Math.Round(GetDistance(), 1)} mph, Speed {Math.Round(_speed, 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile\n");
    }





}