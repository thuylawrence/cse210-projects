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
    
    public bool IsInUSA()
    {
        return _country.ToUpper().Contains("USA") ? true : false;
        
    }

    
    public string GetCountry()
    {
        return _country;
    }
    public string DisplayGetAddress()
    {
        return $"{_streetAddress}|{_city}|{_state}|{_country}";
    }

    
}