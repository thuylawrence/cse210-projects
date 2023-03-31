using System;

class Order
{
    public double _runningTotal;
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    

    public Order(Customer customer)
    {
        
       
        _customer = customer;
    }

    public void DisplayAllProductName()
    {
        _products.ForEach(product => product.DisplayProduct());
    }
    public double GetTotalOrderCost()
    {
        double shipping = _customer.GetAddress().IsInUSA() ? 5 : 35;
        _products.ForEach(product => _runningTotal+=product.GetTotalProductPrice());
        return _runningTotal + shipping;
    }
    public void DisplayFinalOrder()
    {   
        DisplayPackingLabel();
        DisplayShippingLabel();
        Console.WriteLine(GetTotalOrderCost());
        Console.WriteLine();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void DisplayPackingLabel()
    {
        _products.ForEach(product => Console.WriteLine($"{product.GetQuantity()}. {product.GetName()} {product.GetId()} "));
        
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{_customer.GetCustomerName()} - {_customer.GetAddress().DisplayGetAddress()}");
        
    }
        
        




}