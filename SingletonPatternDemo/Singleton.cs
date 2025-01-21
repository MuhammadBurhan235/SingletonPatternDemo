using System;

public class Singleton
{
    private static Singleton _instance;

    private static readonly object _lock = new object();

    private Singleton()
    {
        Console.WriteLine("Singleton instance created!");
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine($"Message from Singleton: {message}");
    }
}
