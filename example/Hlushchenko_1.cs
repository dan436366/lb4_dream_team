using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class Hlushchenko_1
    {
        public static void Change(ref int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) % 2 == 1)
                {
                    counter++;
                }
            }
            int j = 0;
            int[] result = new int[array.Length - counter];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) % 2 != 1)
                {
                    result[j] = array[i];
                    j++;
                }
            }
            array = result;
        }
    }
    public partial class Hlushchenko_2
    {
        public static void Change(ref int rows, int col, ref int[][] array)
        {
            int sizeOfArray;
            if (rows % 2 == 1)
            {
                sizeOfArray = rows / 2 + 1;
            }
            else
            {
                sizeOfArray = rows / 2;
            }
            int[][] result = new int[sizeOfArray][];
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    result[sizeOfArray - sizeOfArray + k] = new int[col];
                    for (int j = 0; j < col; j++)
                    {
                        result[k][j] = array[i][j];
                    }
                    k++;
                }
            }
            rows = sizeOfArray;
            array = result;
        }
    }
}