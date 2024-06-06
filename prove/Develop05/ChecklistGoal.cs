using System;
using System.Drawing;

public class ChecklistGoal : Goal
{
    //whenever it has a child class set to protected othewise ake them private 
    private int _amountComplete;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, bool isComplated) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountComplete = 0;
        _isComplete = isComplated;
    }
    public ChecklistGoal(string name, string description, int points, int target, int amountCompleate, int bonus, bool isComplated) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountComplete = amountCompleate;
        _isComplete = isComplated;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _amountComplete += 1;
            if (_amountComplete == _target)
            {

                return _points + _bonus;
            }
            else
            {
                return _points;
            }

        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {//should add a check mark here or in the goal manager function?
        return $"{base.GetDetailsString()} -- Progress status {_amountComplete}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName}|{_description}|{_points}|{_isComplete}|{_bonus}|{_amountComplete}|{_target}";
    }

}