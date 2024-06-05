using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming activity1 = new Swimming(20, 2024, 06, 04, 30);
        activity1.GetSummary();
        Console.WriteLine("-----------------------------------------------------");

        Cycling activity2 = new Cycling(20, 2024, 06, 04, 40);
        activity2.GetSummary();
        Console.WriteLine("-----------------------------------------------------");

        Running activity3 = new Running(20, 2024, 06, 04, 10.0);
        activity3.GetSummary();

        Console.WriteLine("-----------------------------------------------------");




    }
}