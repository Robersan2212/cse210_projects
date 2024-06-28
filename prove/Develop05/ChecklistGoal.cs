public class ChecklistGoal : Goal
{
    private int target;
    private int currentCount;
    private int points;
    private int bonusPoints;

    public ChecklistGoal(string name, int target, int points, int bonusPoints) : base(name)
    {
        this.target = target;
        this.points = points;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            currentCount++;
            if (currentCount >= target)
            {
                isCompleted = true;
            }
        }
    }

    public override void Progress()
    {
        // Checklist goal does not have a separate progress method
    }

    public override int GetScore()
    {
        return currentCount * points + (isCompleted ? bonusPoints : 0);
    }

    public override void Display()
    {
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name}: Completed {currentCount}/{target} times - {GetScore()} points");
    }
}
