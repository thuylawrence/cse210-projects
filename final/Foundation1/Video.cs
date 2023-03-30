using System;

class Video
{
    private string _title, _author;
    private int _length;

    List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void DisplayAllVideoComments()
    {

        _comments.ForEach(comment => comment.DisplayComment());
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}, number of comment: {_comments.Count()}");
        DisplayAllVideoComments();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}
