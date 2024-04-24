using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Insert your name:");
            string userName = Console.ReadLine();
            return userName;

        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            string favoriteNumStr = Console.ReadLine();
            int favoriteNum = int.Parse(favoriteNumStr);
            return favoriteNum;
        }

        static int SquareNumber(int number)
        {
            int squareNum = number * number;
            return squareNum;
        }



        static void DisplayResult()
        {
            int userNum = 0;
            int squareNum = 0;
            string userName = "";
            DisplayMessage();
            userName = PromptUserName();
            userNum = PromptUserNumber();
            squareNum = SquareNumber(userNum);
            Console.Write($"{userName}, the square of your number is {squareNum}");

        }

        DisplayResult();


    }
}