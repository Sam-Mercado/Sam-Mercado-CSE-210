using System;

class Program
{
    static void Main(string[] args)
    {//title, description, date, time, street, city, state, country, speaker, capacity
        Lecture event1 = new Lecture("How to Manage Your time right", "6/3/2024", "19:30", "123 stadium", "Tiquipaya", "Cochabamba", "BO", "Brian Tracy", 10);
        event1.FullDetails();
        Console.WriteLine($"\n{event1.ShortDescription()}");
        Console.WriteLine("\n-----------------------------------------------");


        Receptions event2 = new Receptions("Relaxing Session", "6/7/2024", "17:00", "123 stadium", "Tiquipaya", "Cochabamba", "BO");

        event2.Register("Samuel Mercado");
        event2.Register("David Vazques ");
        event2.Register("Rodrigo Pi");

        event2.FullDetails();

        Console.WriteLine($"\n{event2.ShortDescription()}");

        OutdoorGatherings event3 = new OutdoorGatherings("How to overcome an addciton", "6/7/2024", "17:00", "123 stadium", "Tiquipaya", "Cochabamba", "BO");

        event3.FullDetails();
        Console.WriteLine($"\n{event3.ShortDescription()}");


    }
}