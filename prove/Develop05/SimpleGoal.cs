using System;

public abstract class SimpleGoal : Goal
{
    protected bool _IsComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        int timesCompleated = 0;

        if (_IsComplete != true)
        {

            _IsComplete = true;
            timesCompleated += 1;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
        _points = timesCompleated * _points;
        return _points;

    }

    public virtual bool IsComplete()
    {
        if (_IsComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:|{_shortName}|{_description}|{_points}|{_IsComplete}";
    }

}