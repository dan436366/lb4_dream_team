using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    public partial class Lilia
    {
        //Знищити T елементів, починаючи з номеру К(лише якщо всі такі елементи фактично є в масиві)
        public static int[] Rishennya(ref int[] arr)
        {
            Console.WriteLine("Введіть кількість елементів, які потрібно знищити:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть починаючи з якого номеру знищити елементи:");
            int k = int.Parse(Console.ReadLine());
            if (arr == null || t < 0 || k < 0 || t + k > arr.Length)
            {
                Console.WriteLine("Видалити неможливо, " +
                "iндекс поза допустимими межами");
                return arr;
            }
            else
            {
                int[] new_arr = new int[arr.Length - t];
                for (int i = 0; i < k; i++)
                {
                    new_arr[i] = arr[i];
                }
                for (int i = k; i < new_arr.Length; i++)
                {
                    new_arr[i] = arr[i + t];
                }
                return new_arr;
            }
        }
    }
}
