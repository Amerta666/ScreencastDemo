using System;

namespace YoutubeScreencast002
{


    // Дан двумерный массив заполненный случайными числами
    // Есть возможность домножить его на какое-то число
    // Представить каждую строку отдельным одномерным массивом
    // Подсчитать сумму чисел каждого получившегося одномерного массива и вывести на экран

    class Program
    {
        static int[,] CreateMatrix(int row, int col)
        {
            return new int[row, col];
        }
        static void FillMatrix(ref int[,] matr)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            int row = matr.GetLength(0), col = matr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matr[i, j] = random.Next(10);
                }
            }
        }
        static void PrintMatrix(int[,] matr)
        {
            int row = matr.GetLength(0), col = matr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matr[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int[,] MultiplicationMatrixByNumber(ref int[,] matr, int n)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            int row = matr.GetLength(0), col = matr.GetLength(1);
            var res = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    res[i, j] = matr[i, j] * n;
                }
            }
            return res;
        }
        static int[][] GetArrayElements(int[,] matr)
        {
            int row = matr.GetLength(0), col = matr.GetLength(1);

            int[][] rowElements = new int[row][];

            for (int i = 0; i < row; i++)
            {
                rowElements[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    rowElements[i][j] = matr[i, j];
                }
            }
            return rowElements;
        }
        static int[] SumElements(int[][] arg)
        {
            int row = arg.Length, col;
            int[] sumElements = new int[row];
            for (int i = 0; i < row; i++)
            {
                int temp = 0;
                col = arg[i].Length;

                for (int j = 0; j < col; j++)
                {
                    temp += arg[i][j];
                }
                sumElements[i] = temp;
            }
            return sumElements;
        }
        static void PrintArraySumElements(int[] arg)
        {
            int len = arg.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Строка # {i}: {arg[i]}");
            }
        }

        static void Main()
        {

            #region _

            int[,] matr = CreateMatrix(5, 5);

            FillMatrix(ref matr);
            PrintMatrix(matr);

            matr = MultiplicationMatrixByNumber(ref matr, 10);

            PrintMatrix(matr);

            int[][] rowElements = GetArrayElements(matr);
            int[] sumElements = SumElements(rowElements);
            PrintArraySumElements(sumElements);


            #endregion













            Console.ReadLine();
        }
 
    }








}
