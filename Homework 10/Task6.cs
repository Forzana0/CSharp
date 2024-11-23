using System;
using System.Linq;

public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

public class Array : ICalc2
{
    private int[] values;

    public Array(int[] values)
    {
        this.values = values;
    }

    public int CountDistinct()
    {
        return values.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        return values.Count(x => x == valueToCompare);
    }
}

class Program6
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 3, 4, 4, 5, 5, 6 };
        Array array = new Array(arr);

        Console.WriteLine($"Count of distinct values: {array.CountDistinct()}");
        Console.WriteLine($"Count of values equal to 4: {array.EqualToValue(4)}");
    }
}
