using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Task5
    {
        static void Main()
        {
            Console.Write("Введіть арифметичний вираз (тільки + та -): ");
            string expression = Console.ReadLine();
            try
            {
                var result = new DataTable().Compute(expression, null);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}
