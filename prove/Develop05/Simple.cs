public class SimpleGoal : Goal
{
    private string description;
    private int points;

    public SimpleGoal(string name, string description, int points) : base(name)
    {
        this.description = description;
        this.points = points;
    }

    public override void RecordEvent()
    {
        isCompleted = true;
    }

    public override void Progress()
    {
        // Simple goal does not have progress tracking
    }

    public override int GetScore()
    {
        return isCompleted ? points : 0;
    }

    public override void Display()
    {
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name}: {description} - {points} points");
    }
}
