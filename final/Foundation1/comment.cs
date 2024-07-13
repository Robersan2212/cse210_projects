using System;

public class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Commenter: {this.commenterName}");
        Console.WriteLine($"Comment: {this.text}");
    }
}
