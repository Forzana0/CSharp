using System;

public interface IOutput
{
    void Show();
    void Show(string info);
}

public class Array : IOutput
{
    private int[] values;

    public Array(int[] values)
    {
        this.values = values;
    }

    public void Show()
    {
        Console.WriteLine("Array elements:");
        foreach (var value in values)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Show();
        Console.WriteLine(info);
    }
}

class Program1
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        Array array = new Array(arr);

        array.Show();
        array.Show("This is an array of integers.");
    }
}
