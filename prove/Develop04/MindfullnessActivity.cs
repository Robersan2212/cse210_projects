using System;

public abstract class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void Prepare()
    {
        Console.WriteLine($"Preparing for {name}...");
        ShowAnimation();
    }

    public abstract void Start();

    public void End()
    {
        Console.WriteLine($"Good job! You have completed the {name} activity for {duration} seconds.");
        ShowAnimation();
    }

    protected void ShowAnimation()
    {
        Console.WriteLine("Showing animation...");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
