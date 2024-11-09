using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            FileName = "notepad.exe",
            UseShellExecute = false 
        };

        Process process = Process.Start(startInfo);

        process.WaitForExit();

        Console.WriteLine($"Процес завершено з кодом: {process.ExitCode}");
    }
}
