using System;

class Fraction 
{
    private int _topNumbers;
    private int _bottomNumbers;

    public Fraction()
    {
        _topNumbers = 1;
        _bottomNumbers = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumbers = wholeNumber;
        _bottomNumbers = 1;
    }

    public Fraction( int topNumbers, int bottomNumbers)
    {
        _topNumbers = topNumbers;
        _bottomNumbers = bottomNumbers;
    }
    public string GetFractionString()
    {
        string text = $"{_topNumbers}/{_bottomNumbers}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumbers / (double)_bottomNumbers;
    }
}