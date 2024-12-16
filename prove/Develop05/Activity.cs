using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name}...\n");
        Console.WriteLine(Description);
        Console.WriteLine("\nDuration: {0} seconds.", duration);
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(5);
    }

    public void EndActivity(int duration)
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"Activity: {Name}, Duration: {duration} seconds.");
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (var c in "|/-\\")
            {
                Console.Write(c);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
        }
    }

    public abstract void PerformActivity(int duration);
}
