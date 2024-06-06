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

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string mark = IsComplete() ? "X" : " "; //tenery operator
        return $"[{mark}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();


}