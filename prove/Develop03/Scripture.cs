using System;

using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        //if (reference == null || string.IsNullOrEmpty(text))
        // {
        //    throw new ArgumentException("Invalid input for Scripture constructor.");
        //}
        _reference = reference;
        //_words = new List<Word>(text.Split("").Select(word => new Word(word)));
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
        //split the words in text and store each as a word object in th list _words


    }
    public void HideRandomWords(int numberToHide)
    {

        Random rng = new Random();

        for (int i = 0; i <= numberToHide; i++)
        {
            int index;
            do
            {
                index = rng.Next(_words.Count);

            }
            while (_words[index].IsHidden());

            _words[index].Hide();



            if (IsCompletelyHidden())
            {
                break;
            }


        }
        // FOR i <- 0 WHILE i < numberToHide STEP i++
        //      index
        //      DO
        //          index <- rng.NEXT( _words.Count )
        //      WHILE _words[ index ].IsHidden()
        //      
        //      _words[ index ].Hide()
        //      IF IsCompletelyHidden()
        //          BREAK
    }
    public string GetDisplayText()
    {
        string displayText = "";
        displayText += _reference.GetDisplaytext() + "  ";
        foreach (Word w in _words)
        {
            displayText += w.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}
