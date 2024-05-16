using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assigment = new Assignment("Samuel Mercado ", "Math ");
        Console.WriteLine();
        Console.WriteLine(assigment.GetSummary());

        MathAssignment o2 = new MathAssignment("Pedro Mercado ", "Divition", "7-3 ", "8-19 ");
        Console.WriteLine();
        Console.WriteLine(o2.GetSummary());
        Console.WriteLine(o2.GetHomeworkList());

        WritingAssigment o3 = new WritingAssigment("Martha Ortencia ", "History", "Creation of man");
        Console.WriteLine();
        Console.WriteLine(o3.GetSummary());
        Console.WriteLine(o3.GetWrittingInformation());

    }
}