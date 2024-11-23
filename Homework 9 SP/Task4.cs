using System;
using System.Linq;
using System.Threading.Tasks;

class Program4
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Task<int> minTask = Task.Run(() => numbers.Min());
        Task<int> maxTask = Task.Run(() => numbers.Max());
        Task<double> avgTask = Task.Run(() => numbers.Average());
        Task<int> sumTask = Task.Run(() => numbers.Sum());

        Task.WhenAll(minTask, maxTask, avgTask, sumTask).Wait();

        Console.WriteLine($"Min: {minTask.Result}");
        Console.WriteLine($"Max: {maxTask.Result}");
        Console.WriteLine($"Average: {avgTask.Result}");
        Console.WriteLine($"Sum: {sumTask.Result}");
    }
}
