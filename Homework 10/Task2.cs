using System;
using System.Linq;

public interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

public class Array : IMath
{
    private int[] values;

    public Array(int[] values)
    {
        this.values = values;
    }

    public int Max()
    {
        return values.Max();
    }

    public int Min()
    {
        return values.Min();
    }

    public float Avg()
    {
        return values.Average();
    }

    public bool Search(int valueToSearch)
    {
        return values.Contains(valueToSearch);
    }
}

class Program2
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Array array = new Array(arr);

        Console.WriteLine($"Max: {array.Max()}");
        Console.WriteLine($"Min: {array.Min()}");
        Console.WriteLine($"Avg: {array.Avg()}");
        Console.WriteLine($"Search 5: {array.Search(5)}");
        Console.WriteLine($"Search 10: {array.Search(10)}");
    }
}
