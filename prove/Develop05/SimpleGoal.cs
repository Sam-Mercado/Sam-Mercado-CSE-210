using System;

public class SimpleGoal : Goal
{
    protected bool _IsComplete;

    public SimpleGoal(string name, string description, int points, bool isCompleated) : base(name, description, points)
    {
        _IsComplete = isCompleated;

    }

    public override int RecordEvent()
    {

        if (_IsComplete != true)
        {

            _IsComplete = true;
            return _points;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }


    }

    public override bool IsComplete()//is supposed to be a getter 
    {
        return _IsComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{_IsComplete}";
    }

}