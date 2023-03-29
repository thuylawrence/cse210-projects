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
    public List<string> _commentList1 = new List<string>()
    {
        "Commenter: Abhishek Sahu|Text: Amazingly sung",
        "Commenter: A A|Text: Amazing!! unbelievably sung :) ",
        "Commenter: economics12|Text: Well done son!"
    };
    public List<string> _commentList2 = new List<string>()
    {
        "Commenter: OrdinaryLatvian|Text: Your timing is absolutely perfect. Great cover!",
        "Commenter: Tim Splinter|Text: Wild how the fretless-ness adds more 'Jaco'-ness to it even on an upright.",
        "Commenter: Skogstroll69|Text: Nailed it. Completely nailed it. This should be an official version."
    };
    public List<string> _commentList3 = new List<string>()
    {
        "Commenter: ModocMonster|Text: I've seen such a small person play violin before. amazing",
        "Commenter:Farras Hibban|Text: If the double bassist hadn't followed andrew, the iconic performance wouldn't have happened",
        "Commenter: That guy lui|Text: That bass is my favourite part of the song"
    };
}