using System;
using System.Threading;

class Task1
{
    static void Main()
    {
        Thread thread = new Thread(DisplayNumbers);
        thread.Start();
    }

    static void DisplayNumbers()
    {
        for (int i = 0; i <= 50; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}
