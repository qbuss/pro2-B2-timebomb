using System;
using System.Timers;
public class Example
{
    static System.Timers.Timer aTimer;

    static void Main()
    {
        SetTimer();

        Console.WriteLine("bomb is begonnen om "+ DateTime.Now.Hour + ":" + DateTime.Now.Minute);
        Console.WriteLine("bomb gaat elke 10 seconden over. Click enter om eruit te gaan");
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

        Console.WriteLine("Terminating the application...");
    }

    static void SetTimer()
    {
        // 10 seconden (tijd staat in ms)
        aTimer = new System.Timers.Timer(10000);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("BOOOM!!!! " + DateTime.Now.Second);
    }
}
