using System;
using System.Linq;
using System.Threading;

class Task4
{
    static void Main()
    {
        Random rand = new Random();
        int[] numbers = new int[10000];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 1001);
        }

        Thread maxThread = new Thread(() => FindMax(numbers));
        Thread minThread = new Thread(() => FindMin(numbers));
        Thread avgThread = new Thread(() => FindAverage(numbers));

        maxThread.Start();
        minThread.Start();
        avgThread.Start();

        maxThread.Join();
        minThread.Join();
        avgThread.Join();
    }

    static void FindMax(int[] numbers)
    {
        int max = numbers.Max();
        Console.WriteLine($"Максимум: {max}");
    }

    static void FindMin(int[] numbers)
    {
        int min = numbers.Min();
        Console.WriteLine($"Мінімум: {min}");
    }

    static void FindAverage(int[] numbers)
    {
        double average = numbers.Average();
        Console.WriteLine($"Середнє: {average}");
    }
}
