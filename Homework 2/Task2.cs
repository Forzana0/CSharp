using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Task2
    {
        static void Main()
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-100, 101);
                }
            }

            Console.WriteLine("Матриця:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            int min = array[0, 0], max = array[0, 0];
            (int minRow, int minCol) = (0, 0);
            (int maxRow, int maxCol) = (0, 0);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            int sumBetween = 0;
            if (minRow < maxRow || (minRow == maxRow && minCol < maxCol))
            {
                for (int i = minRow; i <= maxRow; i++)
                {
                    for (int j = (i == minRow ? minCol + 1 : 0); j <= (i == maxRow ? maxCol - 1 : 4); j++)
                    {
                        sumBetween += array[i, j];
                    }
                }
            }
            else
            {
                for (int i = maxRow; i <= minRow; i++)
                {
                    for (int j = (i == maxRow ? maxCol + 1 : 0); j <= (i == minRow ? minCol - 1 : 4); j++)
                    {
                        sumBetween += array[i, j];
                    }
                }
            }

            Console.WriteLine($"Сума елементів між {min} і {max}: {sumBetween}");
        }
    }
}
