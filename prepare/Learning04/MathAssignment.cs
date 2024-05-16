class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;
    public MathAssignment(string student, string topic, string textbookSection, string problem) : base(student, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }
    //public string GetTextBook(){
    //    return _textbookSection;
    //}

    //public string GetProblem(){
    //    return _problem;
    //}

    public string GetHomeworkList()
    {
        return "Section: " + _textbookSection + "Problem: " + _problem;
    }
}