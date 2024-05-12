using System;

using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _word;
    public Scripture(Reference reference, string text)
    {
        if (reference == null || string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Invalid input for Scripture constructor.");
        }
        _reference = reference;
        _word = new List<Word>(text.Split("").Select(word => new Word(word)));

    }
    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide >= 0 && numberToHide < _word.Count){
            _word[numberToHide].Hide(); 
            //Word hide = _word[numberToHide];
            //string wordText = hide._text;
            //for (int i = 0; i < wordText.Length; i++)
            //{ 
            //    Console.Write("_");
            //}

            //Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid word index.");
        }
        

    }

    public string GetDisplayText()
    {
        string displayText= "";
        foreach(Word w in _word){
            if(w._isHidden){
                for (int i = 0; i < w._text.Length; i++)
                {
                    displayText += "_";
                }
                displayText += " ";
            }
            else
            {
                displayText += w._text + " ";
            }
         }
        return displayText.Trim();
        }

    public bool IsCompletelyHidden() {
        foreach (Word w in _word)
        {
            if (!w._isHidden)
            {
                return false;
            }
        }
        return true;
     }

}
