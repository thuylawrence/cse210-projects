using System;

public abstract class Event
{
    private string _eventTitle, _eventDescription, _date, _time, _type, _email, _weather, _message;
    
    private Address _address;

    public string EventTitle { get => _eventTitle; set => _eventTitle = value; }
    public string EventDescription { get => _eventDescription; set => _eventDescription = value; }
    public string Date { get => _date; set => _date = value; }
    public string Time { get => _time; set => _time = value; }
    public string Type { get => _type; set => _type = value; }
    public string Email { get => _type; set => _email = value; }
    public string Weather { get => _type; set => _weather = value; }
    public string Message { get => _type; set => _message = value; }

    public Address Address { get => _address; set => _address = value; }

    public Event(string eventTitle, string eventDescription, string date, string time, string address)
    {
        EventTitle = eventTitle;
        EventDescription = eventDescription;
        Date = date;
        Time = time;
    

        string[] addressParts = address.Split(", ");
        Address = new Address(addressParts[0], addressParts[1], addressParts[2], addressParts[3]);
    }
    public void DisplayStandardDetail()
    {
        Console.WriteLine(EventTitle);
        Console.WriteLine(EventDescription);
        Console.WriteLine(Date);
        Console.WriteLine(Time);
        Console.WriteLine(Address.DisplayAddress());
        Console.WriteLine();
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine(Type);
        Console.WriteLine(EventTitle);
        Console.WriteLine(Date);
        Console.WriteLine();
    }
    public abstract void DisplayFullDetails();
    
    
    public void DisplayMarketingMessage()
    {
       Console.WriteLine($"We are here to help our plan your {Type}. All you have to do is contact us, sit back and relax. We will plan a memorable event for you. ");
    }

    

}