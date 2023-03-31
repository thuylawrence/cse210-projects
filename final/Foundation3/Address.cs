



public class Address 
{
    private string _streetAddress, _city, _state, _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    
    
    
    
    public string DisplayAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    
}