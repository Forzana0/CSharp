using System;
using System.Threading;

class Task2
{
    static void Main()
    {
        Console.Write("Введіть початок діапазону: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Введіть кінець діапазону: ");
        int end = int.Parse(Console.ReadLine());

        Thread thread = new Thread(() => DisplayNumbers(start, end));
        thread.Start();
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
