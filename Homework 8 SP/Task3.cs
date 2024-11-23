using System;
using System.Threading;

class Program3
{
    static int visitorCount = 0;

    static void VisitSite()
    {
        Interlocked.Increment(ref visitorCount);
    }

    static void Main()
    {
        int numThreads = 1000;

        Thread[] threads = new Thread[numThreads];
        for (int i = 0; i < numThreads; i++)
        {
            threads[i] = new Thread(VisitSite);
            threads[i].Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine($"Total number of visitors: {visitorCount}");
    }
}
