using System;

public class Program
{
    public static void Main(string[] args)
    {
        VideoManager manager = new VideoManager();

        Video video1 = new Video("Intro to C#", "Alice", 600);
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Jane", "Very helpful, thanks!"));

        Video video2 = new Video("Advanced C#", "Bob", 1200);
        video2.AddComment(new Comment("Mark", "Can't wait to try this."));
        video2.AddComment(new Comment("Lucy", "This is amazing!"));

        Video video3 = new Video("C# Design Patterns", "Charlie", 900);
        video3.AddComment(new Comment("Dave", "Well explained!"));

        manager.AddVideo(video1);
        manager.AddVideo(video2);
        manager.AddVideo(video3);

        manager.DisplayAllVideos();
    }
}

