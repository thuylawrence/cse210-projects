using System;

class Customer
{
    private string _customerName;

    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public void DisplayGetCountry()
    {
        Console.WriteLine(_address.GetCountry());
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    
}