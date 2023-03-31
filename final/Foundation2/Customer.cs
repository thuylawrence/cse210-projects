using System;

class Customer
{
    private string _customerName;

    private Address _address;

    public Customer(string customerName, string address)
    {
        _customerName = customerName;
        string[] addressParts = address.Split(", ");
        _address = new Address(addressParts[0],addressParts[1],addressParts[2],addressParts[3]);
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

    public Address GetAddress()
    {
        return _address;
    }
    
}