using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Task7
    {
        static void Main()
        {
            Console.Write("Введіть текст: ");
            string input = Console.ReadLine();
            string badWord = "die";
            int count = 0;

            string censoredText = input.Replace(badWord, new string('*', badWord.Length), StringComparison.OrdinalIgnoreCase);
            count = (input.Length - censoredText.Length) / badWord.Length;

            Console.WriteLine("Результат: " + censoredText);
            Console.WriteLine($"Статистика: {count} заміни слова {badWord}.");
        }
    }
}
