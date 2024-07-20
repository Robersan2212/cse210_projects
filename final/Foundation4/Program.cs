using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 20.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
