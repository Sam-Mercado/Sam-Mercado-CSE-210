using System;

class Program
{
    static void Main(string[] args)
    {
        bool sam = true;

        while (sam)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }

    }
}