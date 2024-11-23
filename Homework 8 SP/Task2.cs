using System;
using System.Threading;

class Program2
{
    static int totalSum = 0;
    static readonly object lockObj = new object();

    static void SumArrayPart(int[] array, int startIndex, int endIndex)
    {
        int partialSum = 0;
        for (int i = startIndex; i < endIndex; i++)
        {
            partialSum += array[i];
        }

        Interlocked.Add(ref totalSum, partialSum);
    }

    static void Main()
    {
        int size = 1000000;
        int[] array = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 100);
        }

        int numThreads = 4;
        int chunkSize = size / numThreads;

        Thread[] threads = new Thread[numThreads];
        for (int i = 0; i < numThreads; i++)
        {
            int start = i * chunkSize;
            int end = (i == numThreads - 1) ? size : start + chunkSize;
            threads[i] = new Thread(() => SumArrayPart(array, start, end));
            threads[i].Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine($"Total sum of array elements: {totalSum}");
    }
}
