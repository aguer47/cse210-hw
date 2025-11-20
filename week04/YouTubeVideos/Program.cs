using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Video 1.
        Video v1 = new Video("Exploring Uganda", "TravelWithMajok", 420);
        v1.AddComment(new Comment("Aduto", "Great video bambi"));
        v1.AddComment(new Comment("John", "Uganda looks beautiful OMG"));
        v1.AddComment(new Comment("Derrick", "Can not wait to visit the pearl of Africa!"));
        videos.Add(v1);

        // Video 2.
        Video v2 = new Video("python Tutorial Basics", "CodeMaster", 600);
        v2.AddComment(new Comment("Bino", "Very helpful lesson."));
        v2.AddComment(new Comment("Sarah", "Thank you for explaining so clearly."));
        v2.AddComment(new Comment("Mike", "Please do  part two sir."));
        videos.Add(v2);

        // Video 3.
        Video v3 = new Video("Healthy Living Tips", "WellnessWorld", 350);
        v3.AddComment(new Comment("Grace", "Love these tips!"));
        v3.AddComment(new Comment("Kim", "So motivating."));
        v3.AddComment(new Comment("Peter", "I learned a lot."));
        videos.Add(v3);

        // Display all videos
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}