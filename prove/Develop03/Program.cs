using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = new(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your own understanding in all your ways acknowledge him, and he will make your paths straight");



        //Console.WriteLine(" ----------------------------------------------------------");


        while (true)
        {


            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press enter to continue or type \"quit\" to exit: ");
            string userinput = Console.ReadLine();

            if (userinput.ToLower() == "quit")
                break;
            if (scripture.IsCompletelyHidden())
                break;

            if (string.IsNullOrEmpty(userinput))
            {
                scripture.HideRandomWords(3);
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("Press enter to continue or type \"quit\" to exit: " + userinput);

            }


        }










        //Console.WriteLine(numHide);

        //Scripture scripture1 = new Scripture(reference1, _text);
        //Console.WriteLine(scripture1.GetDisplayText());








        //Reference reference2 = new Reference("Proverbs", 3, 5);
        //Console.WriteLine(reference2.GetDisplaytext());



    }
}