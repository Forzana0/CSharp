using System;
using System.Diagnostics;

public class Program2
{
    public static void Main()
    {
        Console.WriteLine("Виберіть опцію: 1 - чекати завершення, 2 - примусово завершити процес");
        string userChoice = Console.ReadLine();

        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            FileName = "notepad.exe",
            UseShellExecute = false
        };

        Process process = Process.Start(startInfo);

        if (userChoice == "1")
        {

            process.WaitForExit();
            Console.WriteLine($"Процес завершено з кодом: {process.ExitCode}");
        }
        else if (userChoice == "2")
        {

            process.Kill();
            Console.WriteLine("Процес був примусово завершений.");
        }
    }
}
