using System;

public class Program1
{
    public static void PrintSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        PrintSquare(5, '*');
    }
}
