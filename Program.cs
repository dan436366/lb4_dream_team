using System;
namespace _1501_VyvodDvymarnogoMassiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] arr = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = num[index];
                    index++;
                }
            }
            PrintArr1(arr);
        }
        //static void PrintArr(int[,] arr)
        //{
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.Write(arr[i, j] + " ");

        //        }
        //        Console.WriteLine();

        //    }
        //    //PrintArr1(arr);
        //}
        static void PrintArr1(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}