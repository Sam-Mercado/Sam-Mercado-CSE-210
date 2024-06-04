using System;
using System.Reflection;

public class Receptions : Event
{

    private List<string> _registeredBeforeHand;

    public Receptions(string title, string date, string time, string street, string city, string state, string country)
    : base(title, date, time, street, city, state, country)
    {

        _type = "Receptions";
        _description = ShortDescription();
        _registeredBeforeHand = new List<string>();

        // if (registeredBefroreHand != null){
        //     _registeredBefroreHand.Add(registeredBefroreHand);
        // }
        // else {
        //     Console.WriteLine("Please insert a name.");
        // }
    }

    public void Register(string name)
    {
        _registeredBeforeHand.Add(name);
    }

    public void FullDetails()
    {

        Console.WriteLine($"{StandardDetails()}");
        Console.WriteLine("Reservation Needed\n");

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("People In the List [Intern Only]: ");

        foreach (string i in _registeredBeforeHand)
        {
            Console.WriteLine(i);
        }

    }

    public string ShortDescription()
    {
        return "This type of event requires people to RSVP, or register, beforehand";
    }




}

