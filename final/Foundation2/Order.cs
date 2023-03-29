using System;

class Order 
{
    private List<string> _product = new List<string>()
    {

    };
    private string _customer;
    private List<float> _prices = new List<float>()
    {

    };

    public Order()
    {

    }

    public Order(List<string> product, string customer, List<float> prices)
    {
        _product = product;
        _customer = customer;
        _prices = prices;
    }
    public bool DisplayShippingCost()
    {
        foreach (Price price in _prices)
        {
            if (_address == "USA")
            {
                _shippingCost = "$5";
                float sum = 
            }
            else
            {
                _shippingCost = "$35";
            }
        }
    }
}