using System;

public class BreathingActivity : MindfulnessActivity
{
    private string breathInMessage = "Breathe in...";
    private string breathOutMessage = "Breathe out...";

    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Start()
    {
        Prepare();
        Console.WriteLine(description);
        for (int i = 0; i < duration / 2; i++)
        {
            ShowBreathingCycle();
        }
        End();
    }

    private void ShowBreathingCycle()
    {
        Console.WriteLine(breathInMessage);
        ShowAnimation();
        Console.WriteLine(breathOutMessage);
        ShowAnimation();
    }
}
