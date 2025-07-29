using System;
using week04;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "My First Minecraft Gameplay";
        video1._author = "Tommy11";
        video1._length = 763;

        video1.AddComment(new Comment("Slobo", "You've got talent, bro... just need to figure out where"));
        video1.AddComment(new Comment("GerryHollywood", "Talent runs in your veins, just waiting for it to flow"));
        video1.AddComment(new Comment("RichiePPP", "Things are... drifting away"));
        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Playing with Friends";
        video2._author = "Soli64";
        video2._length = 824;

        video2.AddComment(new Comment("BallMan", "You’re onto something, just not sure what"));
        video2.AddComment(new Comment("Dax117", "A star in the making... once we find the right role"));
        video2.AddComment(new Comment("K-vinTH", "Your potential is limitless... if we ever find it"));
        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Driving to Chicago";
        video3._author = "VickyPaul";
        video3._length = 824;

        video3.AddComment(new Comment("JSG555", "A hidden gem... really, really hidden"));
        video3.AddComment(new Comment("Diiieggoo", "You've got the spark, just need the fire"));
        video3.AddComment(new Comment("TheCein", "Great effort! Now let’s work on the result"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine("-----------------------------------------------");

        }
    }
}