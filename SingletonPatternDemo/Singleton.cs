using System;

public class Singleton
{
    // Static variable untuk menampung instance tunggal
    private static Singleton _instance;

    // Lock object untuk thread-safety
    private static readonly object _lock = new object();

    // Private constructor agar tidak bisa di-instantiate dari luar
    private Singleton()
    {
        Console.WriteLine("Singleton instance created!");
    }

    // Public method untuk mengakses instance tunggal
    public static Singleton Instance
    {
        get
        {
            // Double-checked locking untuk memastikan thread-safety
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

    // Contoh method dalam Singleton
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"Message from Singleton: {message}");
    }
}
