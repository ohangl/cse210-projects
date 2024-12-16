using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What made this time different from other times?",
        "How did you feel when it was complete?",
        "What could you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "Welcome to the Reflection Activity! This activity helps you reflect on moments of strength and resilience.") { }

    public override void PerformActivity(int duration)
    {
        StartActivity(duration);

        var random = new Random();
        Console.WriteLine("\n" + Prompts[random.Next(Prompts.Count)]);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + Questions[random.Next(Questions.Count)]);
            ShowSpinner(5);
        }

        EndActivity(duration);
    }
}
