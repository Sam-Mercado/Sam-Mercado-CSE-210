class Customer
{

    protected string _name;
    protected Address _address;

    public Customer(string name)
    {
        _name = name;
    }


    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);

    }

    public string GetAdress()
    {
        return _address.DisplayAddress();
    }

    public bool IsFromTheUS()
    {
        return _address.IsFromTheUS();

    }
}