using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Structural and Civil Works Basics", "Argy Milan", 600);
        video1.AddComment(new Comment("Engr. Carlo", "The footing explanation was very clear."));
        video1.AddComment(new Comment("Mika", "This helped me understand slab reinforcement better."));
        video1.AddComment(new Comment("Ben", "Good discussion about concrete pouring and curing."));

        Video video2 = new Video("Electrical and Mechanical Installation", "RG Builds", 480);
        video2.AddComment(new Comment("John", "Very useful guide for conduit installation."));
        video2.AddComment(new Comment("Liza", "The HVAC explanation was simple and easy to follow."));
        video2.AddComment(new Comment("Mark", "I learned proper electrical load computation here."));

        Video video3 = new Video("Finishing and Painting Works", "BYU Pathway Student", 300);
        video3.AddComment(new Comment("Ana", "The skim coat and primer process was explained well."));
        video3.AddComment(new Comment("Grace", "Nice tips for choosing paint finishes."));
        video3.AddComment(new Comment("Judee", "I liked the discussion about wall preparation before painting."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}