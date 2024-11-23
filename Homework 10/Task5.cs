using System;

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public class Array : IOutput2
{
    private int[] values;

    public Array(int[] values)
    {
        this.values = values;
    }

    public void ShowEven()
    {
        Console.WriteLine("Even numbers:");
        foreach (var value in values)
        {
            if (value % 2 == 0)
                Console.WriteLine(value);
        }
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd numbers:");
        foreach (var value in values)
        {
            if (value % 2 != 0)
                Console.WriteLine(value);
        }
    }
}

class Program5
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Array array = new Array(arr);

        array.ShowEven();
        array.ShowOdd();
    }
}
