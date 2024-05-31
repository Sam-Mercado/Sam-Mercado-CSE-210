using System;
using System.Diagnostics;

class Order
{
    protected Customer _name;
    protected List<Product> _productsList;




    public void PackingLable()
    {

    }

    public int Shipping(bool livesIntheUS)
    {

        if (livesIntheUS == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }







}