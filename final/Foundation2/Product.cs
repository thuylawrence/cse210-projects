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

    

    public float productPrice(float _price, int _productQuantity)
    {
        return _price * _productQuantity;
    }
    public void DisplayAllProductName()
    {
        
    }
    
}