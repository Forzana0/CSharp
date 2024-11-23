using System;
using System.Linq;
using System.Threading.Tasks;

class Program5
{
    static async Task Main()
    {
        int[] numbers = { 10, 20, 20, 30, 40, 50, 50, 60 };

        var uniqueNumbersTask = Task.Run(() => numbers.Distinct().ToArray());

        var sortedTask = uniqueNumbersTask.ContinueWith(prevTask => prevTask.Result.OrderBy(n => n).ToArray());

        var searchTask = sortedTask.ContinueWith(prevTask =>
        {
            int[] sortedNumbers = prevTask.Result;
            int index = Array.BinarySearch(sortedNumbers, 30);
            return index >= 0 ? $"Found at index {index}" : "Not found";
        });

        string searchResult = await searchTask;

        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedTask.Result));
        Console.WriteLine(searchResult);
    }
}
