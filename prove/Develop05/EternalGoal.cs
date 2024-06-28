public class EternalGoal : Goal
{
    private int momentsDone;
    private int points;

    public EternalGoal(string name, int points) : base(name)
    {
        this.points = points;
        this.momentsDone = 0;
    }

    public override void RecordEvent()
    {
        momentsDone++;
    }

    public override void Progress()
    {
        // Eternal goal does not have a completion status
    }

    public override int GetScore()
    {
        return momentsDone * points;
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {name}: {momentsDone} moments done - {momentsDone * points} points");
    }
}
