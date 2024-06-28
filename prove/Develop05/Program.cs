using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.AddGoal(new SimpleGoal("Run a Marathon", "Complete a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read Scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend Temple", 10, 50, 500));

        goalManager.RecordEvent("SimpleGoal");
        goalManager.RecordEvent("EternalGoal");
        goalManager.RecordEvent("EternalGoal");
        goalManager.RecordEvent("ChecklistGoal");
        goalManager.RecordEvent("ChecklistGoal");

        goalManager.DisplayScore();
        goalManager.DisplayGoals();
    }
}
