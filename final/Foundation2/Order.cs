using System;

class Order
{
    List<Product> _products = new List<Product>();
    Product product1 = new Product("ProductName: Shoes", 1, 1, 15.6);
    Product product2 = new Product("ProductName: Shirt", 2, 1, 8.5);
    Product product3 = new Product("ProductName: Dress", 3, 1, 17.8);
    public void DisplayAllProductName()
    {
        _products.ForEach(product => product.DisplayProduct)
    }
    private Customer _customer;
    public float GetTotalCost()
    {
        return GetTotalCost;



    }





}