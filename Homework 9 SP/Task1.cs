using System;
using System.Threading.Tasks;

class Program
{
    static void DisplayCurrentDateTime()
    {
        Console.WriteLine($"Current Date and Time: {DateTime.Now}");
    }

    static void Main()
    {
        Task task1 = new Task(DisplayCurrentDateTime);
        task1.Start();

        Task task2 = Task.Factory.StartNew(DisplayCurrentDateTime);

        Task task3 = Task.Run(DisplayCurrentDateTime);

        Task.WhenAll(task1, task2, task3).Wait();
    }
}
