using System;

class WritingAssigment : Assignment
{
    protected string _title;
    public WritingAssigment(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }
    public string GetWrittingInformation()
    {
        return _title + " by " + _student;
    }

}