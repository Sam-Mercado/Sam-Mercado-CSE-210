using System;

public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;



    public Event(string title, string date, string time, string street, string city, string state, string country)
    {
        _title = title;
        _description = "";
        _date = date;
        _time = time;
        _address = new Address(street, city, state, country);
        _type = "";

    }

    public string StandardDetails()
    {
        //Lists the title, description, date, time, and address.
        return $"Event type: [{_type}]\n Title: {_title} \n Description: {_description}\n Happening on: {_date} @ {_time}\n Place:\n {_address.DisplayAddress()}";

    }

    //public void FullDetails(){
    //if title is Lecture: speaker name and capacity.
    //if title is receptions For receptions this includes an email for RSVP
    //if title is Outdoor this includes a statement of the weather.

    //}


}