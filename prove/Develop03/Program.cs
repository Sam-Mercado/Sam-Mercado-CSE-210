using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(reference1.GetDisplaytext());

        Word word1 = new Word("Trust in the LORD with all your heart and lean not on your own understanding in all your ways acknowledge him, and he will make your paths straight");
        Console.WriteLine(word1.GetDisplayText());
        word1.Hide();
        Word numHide = word1;
        //Console.WriteLine(numHide);

        Scripture scripture1 = new Scripture(reference1, _text);
        Console.WriteLine(scripture1.GetDisplayText());







        Console.WriteLine();

        //Reference reference2 = new Reference("Proverbs", 3, 5);
        //Console.WriteLine(reference2.GetDisplaytext());



    }
}