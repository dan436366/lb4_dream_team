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
        static void Choice()
        {
            Console.WriteLine("Натиснiть 1, якщо бажаєте заповнити масив випадковим чином");
            Console.WriteLine("Натиснiть 2, якщо бажаєте заповнити масив вручну в одному рядку");
            int y = int.Parse(Console.ReadLine());
            int[] arr;
            switch (y)
            {
                case 1:
                    arr = Input_Random();
                    Rishennya(arr);
                    break;
                case 2:
                    arr = Input_ByHand();
                    Rishennya(arr);
                    break;
                default:
                    Console.WriteLine("Введено недопустиме значення");
                    break;
            }
        }
        static int[] Input_Random()
        {
            Console.WriteLine("Введiть кiлькiсть елементiв массиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            PrintArr(arr);
            return arr;
        }
        static int[] Input_ByHand()
        {
            Console.WriteLine("Введiть кiлькiсть елементiв массиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Введiть {n} елементiв масиву:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        //Знищити T елементів, починаючи з номеру К(лише якщо всі такі елементи фактично є в масиві)
        static int[] Rishennya(int[] arr)
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
                PrintArr(new_arr); 
                return arr;
            }
            
        }
        static void PrintArr(int[] arr)
        {
            Console.WriteLine("Масив має наступний вигляд:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return;
        }

        static void Main(string[] args)
        {
            Choice();
        }
    }
}