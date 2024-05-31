using System;
using System.Collections.Generic;

class Video
{
    protected string _title;
    protected string _author;
    protected int _length;
    protected List<Comment> _commentsList;

    public Video(string title, string author, int length)
    {

        _title = title;
        _author = author;
        _length = length;
        _commentsList = new List<Comment>();


    }

    public int NumberOfComments()
    {
        int numberOfComments = _commentsList.Count;
        return numberOfComments;
    }

    public void AddComment(Comment comment)
    {
        if (_commentsList != null)
        {
            _commentsList.Add(comment);
        }
        else
        {
            Console.WriteLine("The comments list is not initialized.");
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}| {_author}|{_length}");
        foreach (Comment c in _commentsList)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine(NumberOfComments());
    }




}