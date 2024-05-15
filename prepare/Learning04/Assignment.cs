using System;

class Assignment {
    private string _student;
    private string _topic;
    
    public string GetSummary(string student, string topic){
        _student = student;
        _topic = topic;
        return _student + _topic;
    }

}
    