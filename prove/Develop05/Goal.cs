public abstract class Goal
{
    protected string name;
    protected bool isCompleted;

    public Goal(string name)
    {
        this.name = name;
        this.isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract void Progress();
    public abstract int GetScore();
    public abstract void Display();

    public bool IsCompleted()
    {
        return isCompleted;
    }
}
