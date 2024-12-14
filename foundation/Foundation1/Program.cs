using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video
        {
            Title = "Exploring the Mountains of Patagonia",
            Author = "TravelWithMe",
            LengthInSeconds = 600
        };
        video1.AddComment(new Comment("Alicia", "Amazing video, I felt like I was there!"));
        video1.AddComment(new Comment("Paulo", "The scenery is amazing!"));
        video1.AddComment(new Comment("Charlie", "What camera did you use? The quality is great."));

        Video video2 = new Video
        {
            Title = "Learn C# in 10 Minutes",
            Author = "CodeMaster",
            LengthInSeconds = 620
        };
        video2.AddComment(new Comment("Carina", "This was super helpful, thanks!"));
        video2.AddComment(new Comment("Santiago", "Great quick tutorial, I learned a lot."));
        video2.AddComment(new Comment("Maxima", "Is there a part two?"));

        Video video3 = new Video
        {
            Title = "Best Street Food in Argentina",
            Author = "FoodieAdventures",
            LengthInSeconds = 480
        };
        video3.AddComment(new Comment("Lucas", "I’m hungry now, looks delicious!"));
        video3.AddComment(new Comment("Yair", "I’ve tried that noodle place, it’s awesome."));
        video3.AddComment(new Comment("Angela", "More videos like this please!"));

        // optional fourth video
        Video video4 = new Video
        {
            Title = "Top 10 Tips for Productivity",
            Author = "LifeHacksPro",
            LengthInSeconds = 300
        };
        video4.AddComment(new Comment("Jane", "Tip #3 changed my life!"));
        video4.AddComment(new Comment("Kyle", "Great advice, thanks."));
        video4.AddComment(new Comment("Linda", "I’m going to implement these tips today."));

        
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }

        
    }
}
