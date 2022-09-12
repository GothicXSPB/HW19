using System;

namespace Massive2
{
    public class Math
    {
        public static int[,] Create()
        {
            int[,] array = new int[5, 5];
            Random r = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(100, 1000);
                }
            }
            return array;
        }

        public static void Show(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void ShowConsole(int result, string line)
        {
            Console.WriteLine($"{line}: {result}");
        }

        public static void ShowConsole(int[] result, string line)
        {
            Console.Write(line);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + "; ");
            }
            Console.WriteLine();
        }

        //1) Найти минимальный элемент массива

        public static int GetMin(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        //2) Найти максимальный элемент массива

        public static int GetMax(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        //3) Найти индекс минимального элемента массива

        public static int[] GetMinIndex(int[,] array)
        {
            int indexI = 0;
            int indexJ = 0;
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            return new[] { indexI, indexJ };
        }

        //4) Найти индекс максимального элемента массива

        public static int[] GetMaxIndex(int[,] array)
        {
            int indexI = 0;
            int indexJ = 0;
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            return new[] { indexI, indexJ };
        }

        //5) Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.

        public static int AmountMinElement(int[,] array)
        {
            int result = 0;

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1])
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}