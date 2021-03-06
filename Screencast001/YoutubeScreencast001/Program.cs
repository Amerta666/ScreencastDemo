using System;

namespace YoutubeScreencast001
{
    // https://youtu.be/Pf2Xab-vGa4
    // Дан двумерный массив заполненный случайными числами
    // Есть возможность домножить его на какое-то число
    // Представить каждую строку отдельным одномерным массивом
    // Подсчитать сумму чисел каждого получившегося одномерного массива и вывести на экран

    class Program
    {
        static void Main()
        {

            #region _

            int[,] matr = new int[5, 5];

            int row = matr.GetLength(0), col = matr.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matr[i, j] = random.Next(10);
                    Console.Write($"{matr[i, j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matr[i, j] *= 10;
                    Console.Write($"{matr[i, j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            int[][] rowElements = new int[row][];

            for (int i = 0; i < row; i++)
            {
                rowElements[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    rowElements[i][j] = matr[i, j];
                }
            }

            int[] sumElements = new int[row];
            for (int i = 0; i < row; i++)
            {
                int temp = 0;
                for (int j = 0; j < col; j++)
                {
                    temp += rowElements[i][j];
                }
                sumElements[i] = temp;
            }

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"Строка # {i}: {sumElements[i]}");
            }

            #endregion

            Console.ReadLine();
        }

    }
}
