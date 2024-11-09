using System;
using System.Linq;

public class Program3
{
    public static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Where(x => !filterArray.Contains(x)).ToArray();
    }

    public static void Main()
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] result = FilterArray(originalArray, filterArray);

        Console.WriteLine(string.Join(", ", result)); 
    }
}
