using System;
using System.Collections.Generic;

public class VideoManager
{
    private List<Video> videos;

    public VideoManager()
    {
        this.videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        this.videos.Add(video);
    }

    public void DisplayAllVideos()
    {
        foreach (var video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }
    }
}
