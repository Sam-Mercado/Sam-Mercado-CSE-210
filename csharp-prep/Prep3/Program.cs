using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // variables 
        //int attempts=

        //getting the random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);
        //getting the guess from the user 
        Console.Write("What is the magic number?");
        Console.WriteLine(magicNumber);

        string guess = Console.ReadLine();
        int numGuess = int.Parse(guess);

        while (numGuess != magicNumber)
        {
            if (numGuess > magicNumber)
            {
                Console.WriteLine("lower");
                guess = Console.ReadLine();
                numGuess = int.Parse(guess);

            }
            else if (numGuess < magicNumber)
            {
                Console.WriteLine("higher");
                guess = Console.ReadLine();
                numGuess = int.Parse(guess);

            }

        }
        if (numGuess == magicNumber)
        {
            Console.WriteLine("You guess it!!");

        }

    }
}