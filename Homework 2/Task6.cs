using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Task6
    {
        static void Main()
        {
            Console.Write("Введіть текст: ");
            string input = Console.ReadLine();
            string[] sentences = input.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = char.ToUpper(sentences[i].Trim()[0]) + sentences[i].Trim().Substring(1);
            }

            string result = string.Join(". ", sentences) + ".";
            Console.WriteLine("Результат: " + result);
        }
    }
}
