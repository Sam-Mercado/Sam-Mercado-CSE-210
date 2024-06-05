using System;
using System.Diagnostics;

class Order
{
    protected Customer _name;
    protected List<Product> _productsList;
    public Order()
    {

    }

    public Order(string customerName, string street, string city, string state, string country)
    {
        _name = new Customer(customerName, street, city, state, country);
        _productsList = new List<Product>();

    }



    public void AddProduct(Product productToAdd)
    {
        if (_productsList != null)
        {
            _productsList.Add(productToAdd);
        }
        else
        {
            Console.WriteLine("The product list contains noting");
        }
    }



    public void PackingLable()
    {
        int total = 0;
        int plusShipping = 0;
        foreach (Product p in _productsList)//there is an error here
        {
            string productName = p.GetProductName();
            string productID = p.GetProductID();
            int price = p.GetTotal();
            int quantity = p.GetprodutQuantity();
            total = total + price;
            Console.WriteLine($"{productID}-{productName} (Items:{quantity}, Price Each:{price})");
        }
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine($"Total: {total}$");
        Console.WriteLine("\n------------------------------------------------------");
        plusShipping = Shipping() + total;
        Console.WriteLine($"ShippingCost: {Shipping()}$");
        Console.WriteLine($"Total: {plusShipping}$");


    }

    public int Shipping()
    {

        if (_name.IsFromTheUS() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }







}