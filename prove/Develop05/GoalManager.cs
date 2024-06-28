using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"Added goal: {goal.GetType().Name} - {goal}");
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.GetType().Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            UpdateScore();
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    private void UpdateScore()
    {
        score = 0;
        foreach (var goal in goals)
        {
            score += goal.GetScore();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.Display();
        }
    }
}
