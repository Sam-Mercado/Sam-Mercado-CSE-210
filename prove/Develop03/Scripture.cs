using System;

using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        if (reference == null || string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Invalid input for Scripture constructor.");
        }
        _reference = reference;
        _words = new List<Word>(text.Split("").Select(word => new Word(word)));

    }
    public void HideRandomWords(int numberToHide)
    {
        //int hiddenCount = 0;
        //while (hiddenCount <= numberToHide)
        //{
        Random rng = new Random();
        //   int index = rng.Next(_words.Count);
        //    if (!_words[index].IsHidden())
        //    {
        //        _words[index].Hide();
        //        hiddenCount++;
        //    }
        //    if (IsCompletelyHidden())
        //    {
        //        break;
        //    }
        //}
        for (int i = 0; i < numberToHide; i++)
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



    // if (numberToHide >= 0 && numberToHide < _words.Count)
    // {
    //     _words[numberToHide].Hide();
    //     //Word hide = _words[numberToHide];
    //     //string wordText = hide._text;
    //     //for (int i = 0; i < wordText.Length; i++)
    //     //{ 
    //     //    Console.Write("_");
    //     //}

    //     //Console.WriteLine();
    // }
    // else
    // {
    //     Console.WriteLine("Invalid word index.");
    // }


    public string GetDisplayText()
    {
        string displayText = "";
        displayText += _reference.GetDisplaytext() + " - ";
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
