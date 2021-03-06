using System;
using System.IO;
using System.Linq;

namespace YoutubeScreencast003
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
        static int[,] FillMatrix(int[,] matr)
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
            return matr;
        }
        static int[,] MultiplicationMatrixByNumber(int[,] matr, int n)
        {
            int row = matr.GetLength(0), col = matr.GetLength(1);
            var res = new int[row, col]; ;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    res[i, j] = matr[i, j] * n;
                }
            }
            return res;
        }
        static int[,] PrintMatrix(int[,] matr)
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
            return matr;
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
        static int[] PrintArraySumElements(int[] arg)
        {
            int len = arg.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Строка # {i}: {arg[i]}");
            }
            return arg;
        }
        static int[] SaveToFile(int[] arg)
        {
            File.WriteAllLines("fg.txt", arg.Select(e => e.ToString()).ToArray());
            return arg;
        }

        static void Main()
        {

            #region _

            SaveToFile(
                PrintArraySumElements(
                    SumElements(
                        GetArrayElements(
                            PrintMatrix(
                                MultiplicationMatrixByNumber(
                                    PrintMatrix(
                                           FillMatrix(
                                            CreateMatrix(5, 5))),
                                10))))));


            #endregion
        












            Console.ReadLine();
        }

    }
}
