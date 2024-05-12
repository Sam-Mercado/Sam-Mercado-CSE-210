using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(reference1.GetDisplaytext());

        Reference reference2 = new Reference("Proverbs", 3, 5);
        Console.WriteLine(reference2.GetDisplaytext());

    }
}