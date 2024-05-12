using System;


class Word
{
    public string _text;
    public bool _isHidden;

    public Word(string Text)
    {
        _text = Text;
        
    }

    public void Hide()
    {
        int numWords = _text.Length;

        Random random = new Random();
        int randomNumber = random.Next(0, numWords);
        Console.WriteLine(randomNumber);

    }
    public void Show()
    {
        
        Console.Write("");
        
    }
    public bool IsHidden()
    {
        return true;
    }
    public string GetDisplayText(){
        return _text;
     }
}