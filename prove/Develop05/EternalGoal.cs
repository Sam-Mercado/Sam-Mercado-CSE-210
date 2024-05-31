using System;

abstract class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        int timesCompleated = 0;
        if (isComplete())
        {
            timesCompleated += 1;
            _points = timesCompleated * _points;

        }
        return _points;
    }

    public virtual bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:|{_shortName}|{_description}|{_points}";
    }


}
