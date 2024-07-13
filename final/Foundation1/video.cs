using System;
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        this.comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return this.comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Author: {this.author}");
        Console.WriteLine($"Length: {this.length} seconds");
        Console.WriteLine($"Number of Comments: {this.GetNumberOfComments()}");
        foreach (var comment in comments)
        {
            comment.Display();
        }
    }
}
