using System;
using System.ComponentModel.DataAnnotations;


class Word
{
    private string _text; // pass
    private bool _isHidden; // Status (true or false)

    public Word(string Text)
    {
        _text = Text;

    }

    // All logic is foced on the class, or focused on the manipulation of the class variables.

    //
    // SETTERS
    //
    public void Hide()
    {
        _isHidden = true;

    }
    public void Show()
    {

        _isHidden = false;

    }

    //
    // GETTER
    //

    // Return the status of the word
    public bool IsHidden()
    {
        return _isHidden;
    }


    public string GetDisplayText()
    {
        if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}