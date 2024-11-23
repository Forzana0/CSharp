using System;

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

public class Array : ISort
{
    private int[] values;

    public Array(int[] values)
    {
        this.values = values;
    }

    public void SortAsc()
    {
        Array.Sort(values);
        Show();
    }

    public void SortDesc()
    {
        Array.Sort(values);
        Array.Reverse(values);
        Show();
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
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
}

class Program3
{
    static void Main()
    {
        int[] arr = { 5, 3, 8, 6, 1, 9 };
        Array array = new Array(arr);

        Console.WriteLine("Sorting Ascending:");
        array.SortAsc();

        Console.WriteLine("Sorting Descending:");
        array.SortDesc();

        Console.WriteLine("Sorting by Parameter (Asc):");
        array.SortByParam(true);

        Console.WriteLine("Sorting by Parameter (Desc):");
        array.SortByParam(false);
    }
}
