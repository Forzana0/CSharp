namespace Hw2
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Введіть елемент {i + 1} масиву A: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            float[,] B = new float[3, 4];
            Random rand = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = (float)(rand.NextDouble() * 100);
                }
            }

            Console.WriteLine("Масив A: " + string.Join(", ", A));

            Console.WriteLine("Масив B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            int maxA = A[0], minA = A[0], sumA = 0, productA = 1;
            float sumB = 0, productB = 1;
            int evenSumA = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxA) maxA = A[i];
                if (A[i] < minA) minA = A[i];
                sumA += A[i];
                productA *= A[i];
                if (A[i] % 2 == 0) evenSumA += A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sumB += B[i, j];
                    productB *= B[i, j];
                }
            }

            Console.WriteLine($"Максимум: {Math.Max(maxA, (int)B[0, 0])}");
            Console.WriteLine($"Мінімум: {Math.Min(minA, (int)B[0, 0])}");
            Console.WriteLine($"Сума A: {sumA}, Сума B: {sumB}");
            Console.WriteLine($"Добуток A: {productA}, Добуток B: {productB}");
            Console.WriteLine($"Сума парних елементів A: {evenSumA}");

            float oddColumnsSumB = 0;
            for (int j = 0; j < B.GetLength(1); j += 2)
            {
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    oddColumnsSumB += B[i, j];
                }
            }
            Console.WriteLine($"Сума непарних стовпців B: {oddColumnsSumB}");
        }
    }
}
