using System;

namespace lab4
{
    public partial class Popilevych 
    {
        public static int[] EraseB(int[] a, int idx)
        {
            if (a == null || idx < 1 || idx > a.Length)
            {
                Console.WriteLine("Видалити неможливо, " +
                "індекс поза допустимими межами");
                return a;
            }
            else
            {
                int[] b = new int[a.Length - 1];
                for (int i = 0; i < idx - 1; i++)
                {
                    b[i] = a[i];
                }
                for (int i = idx; i < a.Length; i++)
                {
                    b[i - 1] = a[i];
                }
                return b;
            }
        }
        public static void DeleteOddElem(ref int[] array)
        {
            for (int i = array.Length; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    array = EraseB(array, i);
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
