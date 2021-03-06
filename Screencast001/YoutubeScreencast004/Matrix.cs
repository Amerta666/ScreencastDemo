using System;
using System.IO;
using System.Linq;

namespace YoutubeScreencast004
{
    class Matrix
    {
        public int[,] Data { get; set; }

        int[][] rowElements;
        int[] sumElements;
        int row, col;
        Random random;

        public Matrix(int row, int col)
        {
            Data = new int[row, col];
            rowElements = new int[row][];
            sumElements = new int[row];

            random = new Random(Guid.NewGuid().GetHashCode());
            this.row = row;
            this.col = col;
        }

        public Matrix Fill()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Data[i, j] = random.Next(10);
                }
            }
            return this;
        }
        public Matrix Print()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{Data[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return this;
        }
        public Matrix MultiplicationByNumber(int n)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Data[i, j] *= n;
                }
            }
            return this;
        }
        public Matrix GetArrayElements()
        {
            for (int i = 0; i < row; i++)
            {
                rowElements[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    rowElements[i][j] = Data[i, j];
                }
            }
            return this;
        }
        public Matrix SumElements()
        {
            int row = rowElements.Length, col;
         
            for (int i = 0; i < row; i++)
            {
                int temp = 0;
                col = rowElements[i].Length;

                for (int j = 0; j < col; j++)
                {
                    temp += rowElements[i][j];
                }
                sumElements[i] = temp;
            }
            return this;
        }
        public Matrix PrintArraySumElements()
        {
            int len = sumElements.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Строка # {i}: {sumElements[i]}");
            }
            Console.WriteLine();
            return this;
        }
        public Matrix SaveToFile()
        {
            File.WriteAllLines("fg.txt", sumElements.Select(e => e.ToString()).ToArray());
            return this;
        }
    }
}
