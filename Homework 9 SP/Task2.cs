using System;
using System.Threading.Tasks;

class Program2
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

    static void DisplayPrimeNumbers()
    {
        for (int i = 0; i <= 1000; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Main()
    {
        Task primeTask = Task.Run(DisplayPrimeNumbers);

        primeTask.Wait();
    }
}
