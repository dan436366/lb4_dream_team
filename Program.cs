using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3_Krasilnikov
{
    internal class Program
    {

        static void PrintArray(int[,] array)
        {
            Console.WriteLine("Ви отримали масив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

        }



        static bool IsSquareArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (rows != cols)
            {
                return false;
            }

            return true;
        }



        static int[,] FillRandom()
        {

            Console.WriteLine("Введiть кiлькiсть рядкiв масиву");
            int elemRow = int.Parse(Console.ReadLine());


            Console.WriteLine("Введiть кiлькiсть стовпцiв масиву");
            int elemColumn = int.Parse(Console.ReadLine());
            int[,] array = new int[elemRow,elemColumn];

            Random rndGen = new Random();

            for (int i = 0; i < elemRow; i++)
            {
                
                for (int j = 0; j < elemColumn; j++)
                {
                    array[i, j] = rndGen.Next(10,99);
                }
                    
            }


            PrintArray(array);



            Console.WriteLine();


            return array;

        }


        static int[,] FillByPerson()
        {
            
            Console.WriteLine("Введiть кiлькiсть рядкiв масиву");
            int elemRow = int.Parse(Console.ReadLine());


            Console.WriteLine("Введiть кiлькiсть стовпцiв масиву");
            int elemColumn = int.Parse(Console.ReadLine());
            int[,] array = new int[elemRow, elemColumn];

            

            for (int i = 0; i < elemRow; i++)
            {

                for (int j = 0; j < elemColumn; j++)
                {
                    Console.WriteLine("  " + "Ряд " + (i + 1) + " стовпчик " + (j + 1) );
                    array[i,j] = int.Parse(Console.ReadLine());
                }

            }


            PrintArray(array);



            Console.WriteLine();

            return array;

        }

        
        static int[,] ChooseTheWayToFill()
        {
            int[,] array = new int[,] { };

            int num;
                Console.WriteLine("Виберiть метод заповнення масиву 1(випадково) або 2(вручну через Enter)");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        array = FillRandom();
                        break;

                    case 2:
                        array = FillByPerson();
                        break;

                    default:
                        Console.WriteLine("Введiть число з перелiчених");
                        break;
                }

                return array;

            
        }



        static void OddColumnElementsSum(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j += 2)
                {
                    sum += array[i, j];
                }
                Console.WriteLine($"Сума елементiв рядка {i+1}: {sum}");
            }
        }


        static void ChangeNumsColumnDiagonale(int[,] array)
        {
            int n = array.GetLength(0);

            int num = n;

            if (IsSquareArray(array) == true)
            {
                for (int i = 0; i < n; i++)
                {
                    int t = array[i, 0];
                    array[i, 0] = array[i, num - 1];
                    array[i, num - 1] = t;
                    num--;
                }


                Console.WriteLine("Результат пiсля обмiну");

                PrintArray(array);

            }
            else
            {
                Console.WriteLine("Ви повиннi ввести квадратний масив");
            }
            
        }


        static void SortMainDiagonale(int[,] array)
        {
            int n = array.GetLength(0);

            if (IsSquareArray(array) == true)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j, j] > array[j + 1, j + 1])
                        {
                            int temp = array[j, j];
                            array[j, j] = array[j + 1, j + 1];
                            array[j + 1, j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Результат пiсля сортування");

                PrintArray(array);
            }
            else
            {
                Console.WriteLine("Ви повиннi ввести квадратний масив");
            }
        }



        static void SortByMaxElementInColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            
            int[] maxValues = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                maxValues[j] = array[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (array[i, j] > maxValues[j])
                    {
                        maxValues[j] = array[i, j];
                    }
                }
            }

            
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = i + 1; j < cols; j++)
                {
                    if (maxValues[i] < maxValues[j])
                    {
                        
                        for (int k = 0; k < rows; k++)
                        {
                            int temp = array[k, i];
                            array[k, i] = array[k, j];
                            array[k, j] = temp;
                        }

                        
                        int temp2 = maxValues[i];
                        maxValues[i] = maxValues[j];
                        maxValues[j] = temp2;
                    }
                }
            }

            Console.WriteLine("Результат пiсля сортування");
            PrintArray(array);

        }


        static void Main(string[] args)
        {
            
            int choose_block;

            do
            {
                Console.WriteLine("Виберiть, який блок ви хочете виконувати 1, 2, 3, 4 або 0(щоб закрити програму)");

                choose_block = int.Parse(Console.ReadLine());

                switch (choose_block)
                {
                    case 1:
                        OddColumnElementsSum(ChooseTheWayToFill());
                        break;

                    case 2:
                        ChangeNumsColumnDiagonale(ChooseTheWayToFill());
                        break;

                    case 3:
                        SortMainDiagonale(ChooseTheWayToFill());
                        break;

                    case 4:
                        SortByMaxElementInColumn(ChooseTheWayToFill());
                        break;


                    case 0:
                        Console.WriteLine("натиснiть ще раз на любу клавiшу, щоб закрити програму");
                        break;

                    default:
                        Console.WriteLine("Введiть число з перелiчених");
                        break;
                }
            } while (choose_block != 0);
            
        }
    }
}
