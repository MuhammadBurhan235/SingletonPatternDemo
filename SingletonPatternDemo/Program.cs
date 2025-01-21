using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(() =>
        {
            Singleton singleton1 = Singleton.Instance;
            singleton1.DisplayMessage("Thread 1");
        });

        Thread thread2 = new Thread(() =>
        {
            Singleton singleton2 = Singleton.Instance;
            singleton2.DisplayMessage("Thread 2");
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.ReadLine();
    }
}
