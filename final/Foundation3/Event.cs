using System;

public class Event 
{
    protected string _eventTitle, _eventDescription;
    private string _date = DateTime.Now.ToShortDateString();
    private Address _address;

    public Event()
    {
    }

    public Event(string eventTitle, string eventDescription, string date, Address address)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _date = date;
        _address = address;
    }

   

    protected void EventIntroduction()
    {
        Console.WriteLine($"Listing {_eventTitle}. ");
        Console.WriteLine($"Event's description: {_eventDescription}");
        Console.WriteLine($"Location: {_address}");
        StartEvent = DateTime.Now;
    }
    protected DateTime StartEvent;
    protected void DisplayMessages()
    {

    }

}