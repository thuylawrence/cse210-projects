using System;

class Address 
{
    private string _streetAddress, _city, _state, _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetCountry()
    {
        
        if (_country == "USA")
        {
            Console.WriteLine("The shipping cost is $5. ");
        }
        else
        {
            Console.WriteLine("The shipping cost is $35. ");
        }
        return _country;
    }
    private string GetAddress()
    {
        return $"{_streetAddress}|{_city}|{_state}|{_country}";
    }
    
}