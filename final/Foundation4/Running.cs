using System;

public class Running : Activity
{
    protected double _pace;


    public Running(int lenght, int year, int month, int day, double pace) : base(lenght, year, month, day)
    {
        _pace = pace;
        _activity = "Running";
    }

    public override double GetDistance()
    {
        double distance = _lenght / GetPace();
        return distance;
    }


    public override double GetSpeed()
    {
        return 60 / _pace;
    }

    public override double GetPace()
    {

        return _pace;
    }

    public override void GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date} {_activity}({_lenght} min) - Distance {Math.Round(GetDistance(), 1)} mph, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(_pace, 1)} min per mile\n");
    }
}