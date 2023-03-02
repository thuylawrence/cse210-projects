
class Entry 
{
    private string _prompt,_response;
    private string _date = DateTime.Now.ToShortDateString();
    public Entry()
    {
        
    }
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}: {_prompt} {_response}");
    }
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }
    public void SetResponse(string newEntry)
    {
        _response = newEntry;
    }
    public void SetPrompt(string newPrompt)
    {
        _prompt = newPrompt;
    }
    public string GetResponse()
    {
        return _response;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
}
