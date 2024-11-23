using System;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public class Array : ICalc
{
    private int[] values;

    public Array(int[] values)
    {
        this.values = values;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (var value in values)
        {
            if (value < valueToCompare)
                count++;
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (var value in values)
        {
            if (value > valueToCompare)
                count++;
        }
        return count;
    }
}

class Program4
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Array array = new Array(arr);

        Console.WriteLine($"Numbers less than 5: {array.Less(5)}");
        Console.WriteLine($"Numbers greater than 5: {array.Greater(5)}");
    }
}
