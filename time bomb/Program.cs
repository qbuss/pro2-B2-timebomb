using System;
using System.Timers;
public class Example
{
    static System.Timers.Timer aTimer;
    static int aftellen = 10;

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
        aTimer = new System.Timers.Timer(1000);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        
        switch (aftellen)
        {
            case 0:
                Console.WriteLine("BOOM!!");
                break;
            default:
                Console.WriteLine(aftellen + "sec tot explosie");
                aftellen--;
                break;
        }

    }
}
