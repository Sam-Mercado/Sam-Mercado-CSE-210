using System;

class Assignment
{
    protected string _student;
    private string _topic;

    public Assignment(string student, string topic)
    {
        _student = student;
        _topic = topic;
    }
    public string GetStudent()
    {
        return _student;
    }

    //public string GetTopic()
    //{
    //   return _topic
    //}
    public string GetSummary()
    {

        return _student + "- " + _topic;
    }


}
