using System;

class Program
{


    static void Main(string[] args)
    {

        List<Video> _videos = new List<Video>();
        Video video1 = new Video("Title: Caravan-Double Bass Cover", "author: Basso Chan", 144);
        Video video2 = new Video("Title: DCS: Su-33 Cobra carrier landing", "author: Delta", 32);
        Video video3 = new Video("Title: Just the two of us-kazuki isogaii-electric guitar cover", "author: Hyunjung", 52);
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            
            Comment comment1 = new Comment("Commenter: Elijah", "CommentText: Amazing!");
            Comment comment2 = new Comment("Commenter: Kea", "CommentText: I like it! Thank you for posting");
            Comment comment3 = new Comment("Commenter: Kanani", "CommentText: Wow, love the video");
            Comment comment4 = new Comment("Commenter: Jason", "CommentText: That is very cool!");
            video.AddComment(comment1);
            video.AddComment(comment2);
            video.AddComment(comment3);
            video.AddComment(comment4);
        }
        _videos.ForEach(video => video.DisplayVideoInfo());
    }
}