using System;
using System.Diagnostics;

public class Program3
{
    public static void Main()
    {
        Console.Write("Введіть перше число: ");
        string num1 = Console.ReadLine();

        Console.Write("Введіть друге число: ");
        string num2 = Console.ReadLine();

        Console.Write("Введіть операцію (+, -, *, /): ");
        string operation = Console.ReadLine();

        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            FileName = "calc.exe",
            Arguments = $"{num1} {operation} {num2}",
            UseShellExecute = false
        };

        Process process = Process.Start(startInfo);
        process.WaitForExit();
    }
}
