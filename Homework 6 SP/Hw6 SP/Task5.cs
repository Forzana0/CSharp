using System;
using System.Threading;

class Task5
{
    static void Main()
    {
        Thread fibonacciThread = new Thread(Fibonacci);
        fibonacciThread.Start();
    }

    static void Fibonacci()
    {
        int a = 0, b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 2; i < 20; i++)
        {
            int next = a + b;
            Console.WriteLine(next);
            a = b;
            b = next;
            Thread.Sleep(200);
        }
    }
}
