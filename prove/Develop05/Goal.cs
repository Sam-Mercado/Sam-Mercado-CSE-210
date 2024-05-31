using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int point)
    {
        _shortName = name;
        _description = description;
        _points = point;

    }

    public abstract int RecordEvent();

    public abstract bool Iscompleate();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();


}