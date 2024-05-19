using System;

partial class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a Choice from the menu \"number only\"");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breatingActivity = new BreathingActivity();
                breatingActivity.Run();
                //breatingActivity.DisplayStartingMessage();
                //breatingActivity.DisplayEndingMessage();
                //breatingActivity.ShowSpiner(5);
                //breatingActivity.ShowCountDown(5);


            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();

            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();

            }
            else
            {
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a Choice from the menu \"number only\"");
                choice = Console.ReadLine();
            }
        } while (choice != "4");
    }
}