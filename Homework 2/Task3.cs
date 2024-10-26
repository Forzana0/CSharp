using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Task3
    {
        static void Main()
        {
            Console.Write("Введіть текст для шифрування: ");
            string input = Console.ReadLine();
            Console.Write("Введіть зсув: ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = CaesarCipher(input, shift);
            string decrypted = CaesarCipher(encrypted, -shift);

            Console.WriteLine($"Зашифрований текст: {encrypted}");
            Console.WriteLine($"Розшифрований текст: {decrypted}");
        }

        static string CaesarCipher(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
