using System;
using System.Linq;

namespace YoutubeScreencast004
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(5, 5);
            m.Print()
             .Fill()
             .Print()
             .MultiplicationByNumber(10)
             .Print()
             .GetArrayElements()
             .SumElements()
             .PrintArraySumElements();




            Console.ReadLine();

        }
    }
}
