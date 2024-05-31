using System;

class Comment
{

    protected string _name;
    protected string _commentText;


    public Comment(string name, string commentText)
    {

        _name = name;
        _commentText = commentText;
    }

    public override string ToString()
    {
        return $"{_name}: {_commentText}";
    }

}