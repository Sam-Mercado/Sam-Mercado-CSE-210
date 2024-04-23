using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What are your grades?");
        string score = Console.ReadLine();
        int numScore = int.Parse(score);

        if (numScore >= 90){
            Console.Write("Great Job, you got an A !!");
        }
        else if (numScore >= 80){
            Console.Write("Great Job, you got an B !!");
        }
        else if (numScore >= 70){
            Console.Write("You are alsomet there, you got a C !!");
        }
        else if (numScore >= 60){
            Console.Write("Keep pushing, you got a D !!");
        }
        else {
            Console.Write("F You have to work harder");
        }

    }
}