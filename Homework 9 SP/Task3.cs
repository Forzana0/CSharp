using System;
using System.Threading.Tasks;

class Program3
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static Task<int> CountPrimesInRange(int start, int end)
    {
        return Task.Run(() =>
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            return count;
        });
    }

    static async Task Main()
    {
        int start = 0, end = 1000;
        var primeCountTask = CountPrimesInRange(start, end);

        int primeCount = await primeCountTask;

        Console.WriteLine($"Total prime numbers between {start} and {end}: {primeCount}");
    }
}
