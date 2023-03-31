using System;

class Product
{
    private string _productName;

    private int _productId, _productQuantity;
    private double _price;
    

    public Product(string productName, int productId, int productQuantity, double price)
    {
        _productName = productName;
        _productId = productId;
        _productQuantity = productQuantity;
        _price = price;
    }
    public double GetTotalProductPrice()
    {
        return _price * _productQuantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_productQuantity}: {_productName} - ${_price}");
    }

    public int GetQuantity()
    {
        return _productQuantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _productId;
    }
}