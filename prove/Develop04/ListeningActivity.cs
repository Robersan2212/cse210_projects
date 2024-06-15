using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start()
    {
        Prepare();
        Console.WriteLine(description);
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowAnimation();
        CollectList();
        End();
    }

    private void CollectList()
    {
        Console.WriteLine("Start listing items...");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }
        ShowListCount(items.Count);
    }

    private void ShowListCount(int count)
    {
        Console.WriteLine($"You have listed {count} items.");
    }
}
