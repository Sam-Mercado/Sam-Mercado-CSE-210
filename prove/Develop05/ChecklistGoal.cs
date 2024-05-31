using System;

public abstract class ChecklistGoal : Goal
{
    protected int _amountComplete;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountComplete = 0;
    }

    public override int RecordEvent()
    {
        if (Iscompleate())
        {
            _amountComplete += 1;
            _bonus = _amountComplete * _bonus;
        }

        return _bonus;
    }

    public bool IsComplete()
    {
        if (_target != _amountComplete)
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    public override string GetDetailsString()
    {//should add a check mark here or in the goal manager function?
        return $"{_shortName} ({_description}) -- Progress status {_amountComplete}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:|{_shortName}|{_description}|{_bonus}|{_amountComplete}|{_target}|{_points}";
    }

}