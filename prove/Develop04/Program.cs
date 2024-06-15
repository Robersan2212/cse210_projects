using System;
using System.Collections.Generic;

public class MindfulnessApp
{
    private List<MindfulnessActivity> activities = new List<MindfulnessActivity>();
    private MindfulnessActivity currentActivity;
    private MenuSystem menu = new MenuSystem();

    public MindfulnessApp()
    {
        activities.Add(new BreathingActivity());
        activities.Add(new ReflectionActivity());
        activities.Add(new ListingActivity());
    }

    public void Run()
    {
        while (true)
        {
            ShowMenu();
            int choice = menu.GetActivityChoice();
            if (choice < 1 || choice > activities.Count)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
            StartActivity(choice - 1);
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("Choose an activity:");
        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activities[i].GetType().Name}");
        }
        Console.WriteLine("Enter your choice: ");
    }

    private void StartActivity(int index)
    {
        currentActivity = activities[index];
        Console.WriteLine("Enter duration (seconds): ");
        int duration = int.Parse(Console.ReadLine());
        currentActivity.SetDuration(duration);
        currentActivity.Start();
    }
}

public class MenuSystem
{
    public int GetActivityChoice()
    {
        return int.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main(string[] args)
    {
        MindfulnessApp app = new MindfulnessApp();
        app.Run();
    }
}
