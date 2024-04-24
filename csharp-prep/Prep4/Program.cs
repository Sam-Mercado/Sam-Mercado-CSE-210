using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number:");
        string numString = Console.ReadLine();
        int num = int.Parse(numString);

        while (num != 0)
        {
            numbers.Add(num);
            Console.Write("Enter number:");
            numString = Console.ReadLine();
            num = int.Parse(numString);
        }

        //Sum of all numbers in the list: 
        int numSum = 0;
        int listNum = 0;
        float averNum = 0;
        int largestNum = 0;
        if (num == 0)
        {   //get the sum
            foreach (int gotNum in numbers)
            {
                listNum = listNum + 1;
                numSum = numSum + gotNum;
            }
            //get the average
            averNum = numSum / listNum;

            foreach (int i in numbers)
            {
                while (i > largestNum)
                {
                    largestNum = i;
                }
            }

            Console.WriteLine($"The sum is: {numSum}");
            Console.WriteLine($"The average is:{averNum}");
            Console.WriteLine($"The largest number is:{largestNum}");

        }

    }
}