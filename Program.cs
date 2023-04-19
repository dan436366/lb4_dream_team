using System;

namespace podschetstolbikov
{
    class Program
    {
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,10:D}", array[i, j]);

                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int row = int.Parse(data[0]);
            int column = int.Parse(data[1]);
            int[,] array = new int[row, column];
            int[] countEven = new int[column];
            int[] countOdd = new int[column];
            for (int i = 0; i < row; i++)
            {
                string[] inputRow = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = int.Parse(inputRow[j]);

                    if (array[i, j] % 2 == 0)
                    {
                        countEven[j]++;
                    }
                    else
                    {
                        countOdd[j]++;
                    }
                }
            }
            int countColumns = 0;
            for (int j = 0; j < column; j++)
            {
                if (countEven[j] > countOdd[j])
                {
                    countColumns++;
                }
            }
            Console.WriteLine(countColumns);
            for (int j = 0; j < column; j++)
            {
                if (countEven[j] > countOdd[j])
                {
                    Console.Write((j + 1) + " ");
                }
            }
            Console.WriteLine();

        }
    }
}
