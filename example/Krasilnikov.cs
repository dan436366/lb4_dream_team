using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_krasilnikov_block1
{
    public partial class Krasilnikov
    {

        public static void ExtremeMinMax(ref int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] newArr = new int[arr.Length + 2];
            newArr[0] = min;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }


            newArr[newArr.Length - 1] = max;
        }
    }
}
