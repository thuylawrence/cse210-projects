class Word
{
    private string _word;

    private bool _hidden;
    public Word(string text)
    {
        this.SetWord(text);
        this.SetHidden(false);
    }
    public void DisplayWord()
    {
        Console.Write(this.GetWord());
    }
    public bool GetHidden()
    {
        return _hidden;
    }
    public void SetHidden(bool isHidden)
    {
        _hidden = isHidden;
    }
    public string GetWord()
    {
        if(_hidden) {
            return new string('_', _word.Length);
        }
        return _word;
    
    }
    public void SetWord(string text)
    {
        _word = text;
    }
    public void HideWord()
    {
        this.SetHidden(true);
        
    }

}