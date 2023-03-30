using System;

class Comment
{
    private string _commenterName, _text;
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_text}");
    }
}