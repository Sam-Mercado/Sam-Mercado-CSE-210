using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        //add a message that you compleaded a x amount of points 
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}|{_description}|{_points}";
    }


}
