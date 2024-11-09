using System;
using System.Threading;

class Task3
{
    static void Main()
    {
        Console.Write("Введіть кількість потоків: ");
        int numberOfThreads = int.Parse(Console.ReadLine());

        Console.Write("Введіть початок діапазону: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Введіть кінець діапазону: ");
        int end = int.Parse(Console.ReadLine());


        int rangePerThread = (end - start + 1) / numberOfThreads;
        int remainder = (end - start + 1) % numberOfThreads;

        for (int i = 0; i < numberOfThreads; i++)
        {
            int threadStart = start + i * rangePerThread;
            int threadEnd = (i == numberOfThreads - 1) ? end : threadStart + rangePerThread - 1;

            Thread thread = new Thread(() => DisplayNumbers(threadStart, threadEnd));
            thread.Start();
        }
    }

    static void DisplayNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}
