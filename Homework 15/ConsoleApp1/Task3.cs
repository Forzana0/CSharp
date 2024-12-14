using System;

class Program
{
    public delegate bool PredicateOperation(int number);

    static void Main()
    {
        PredicateOperation isEven = IsEven;
        Console.WriteLine("Is 4 even? " + isEven(4));

        PredicateOperation isOdd = IsOdd;
        Console.WriteLine("Is 5 odd? " + isOdd(5));

        PredicateOperation isPrime = IsPrime;
        Console.WriteLine("Is 7 prime? " + isPrime(7));

        PredicateOperation isFibonacci = IsFibonacci;
        Console.WriteLine("Is 8 a Fibonacci number? " + isFibonacci(8));
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        while (b < number)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b == number;
    }
}
