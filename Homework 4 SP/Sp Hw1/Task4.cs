using System;
using System.Diagnostics;
using System.IO;

public class Program4
{
    public static void Main()
    {
        Console.Write("Введіть шлях до файлу: ");
        string filePath = Console.ReadLine();

        Console.Write("Введіть слово для пошуку: ");
        string word = Console.ReadLine();

        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            FileName = "findstr.exe",
            Arguments = $"{word} \"{filePath}\"",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true
        };

        Process process = Process.Start(startInfo);

        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(output))
        {
            int count = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length - 1;
            Console.WriteLine($"Слово '{word}' зустрічається {count} разів у файлі.");
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не знайдено у файлі.");
        }
    }
}
