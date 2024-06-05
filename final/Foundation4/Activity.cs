using System;

public abstract class Activity
{
    //wnat to track date and the length of the activity in minutes.
    protected string _activity;
    protected DateOnly _date;
    protected int _lenght;

    // protected double _distance;
    // protected double _speed;
    // protected double _pace;


    public Activity(int lenght, int year, int month, int day)
    {

        _lenght = lenght;
        _date = new DateOnly(year, month, day);

    }

    public abstract double GetDistance();


    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract void GetSummary();

}