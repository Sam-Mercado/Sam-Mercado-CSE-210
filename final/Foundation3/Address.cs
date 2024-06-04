using System;

public class Address
{
    //street address, the city, state/province, and country.

    protected string _streetAddress;
    protected string _city;
    protected string _state;
    protected string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }


    public string DisplayAddress()
    {
        return $" {_streetAddress} \n  {_city}, {_state} \n  {_country} \n";
    }




}