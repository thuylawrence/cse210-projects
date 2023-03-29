using System;

class Program
{
    

    static void Main(string[] args)
    {
        Video video = new Video();
        string userResponse = "";
        while (userResponse != "QUIT")
        {
            Console.WriteLine("""
            Please pick one of the following videos!
            1. Play the list of videos
            2. Quit
            Please type a number (1-2)
            """);
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                video.GetMovieList();
                video.DisplayVideoList();
            }
            else
            {
                break;
            }
        }
    }

   
}