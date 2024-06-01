class Product
{
    protected string _productName;
    protected int _productID;
    protected int _productPrice;
    protected int _productQuantity;

    public Product(string productName, int productID, int productPrice, int productQuantity)
    {

        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetProductPrice()
    {
        return _productPrice;
    }

    public int GetprodutQuantity()
    {
        return _productQuantity;
    }


    public int GetTotal()
    {

        int total = _productPrice * _productQuantity;
        return total;
    }



}