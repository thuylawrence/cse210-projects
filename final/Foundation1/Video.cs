using System;

class Video
{
    private string _title, _author;
    private int _length;

    List<Comment> _comments = new List<Comment>();
    List<Video> _videos = new List<Video>();

    public Video()
    {

    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void DisplayVideoList()
    {
        
        foreach (Video video in _videos)
        {
            Console.WriteLine(_title, _author, _length);
        }
    }

    public void DisplayVideoComment()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.ReadLine();
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string titleName)
    {
        _title = titleName;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string authorName)
    {
        _author = authorName;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int lengthInSeconds)
    {
        _length = lengthInSeconds;
    }


    public List<string> _videoList = new List<string>()
    {
        "Title: Papa Kehte Hain Bada Naam Karega|Author: Elijah Lawrence|length: 237 seconds",
        "Title: Vulfpeck /// Dean Town (Upright Bass Cover)|Author: Andrew Altman|length: 77 seconds",
        "Title: Caravan - Double Bass Cover (Whiplash)|Author: Basso Chan|length: 143 seconds"
    };
    public List<string> GetMovieList()
    {
        return _videoList;
    }
    
}