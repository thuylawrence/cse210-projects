using System;

class Product
{
    private string _productName;

    private int _productId, _productQuantity;
    private float _price;

    public Product(string productName, int productId, int productQuantity, float price)
    {
        _productName = productName;
        _productId = productId;
        _productQuantity = productQuantity;
        _price = price;
    }
    public float Price()
    {
        return _price;
    }

}