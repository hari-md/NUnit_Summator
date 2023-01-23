using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double Average(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;

        }


        //Sum is the Methed that we created. It can bbe tested with another program from the dev.

        //public static void Test_SumTwoNumbers()
        //{
        //    if (Sum(new int[] { 1, 2 }) != 3)
        //    {
        //        throw new Exception("1+2 != 3");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Test SumTwoNumbers pass!");
        //    }

        //    // Calls method Sum and trows back a NEW exception if 1+2 !=3;
        //}

        //public static void Test_SumEmptyArray()
        //{
        //    if (Sum(new int[] { }) != 0)
        //    {
        //        throw new Exception("sum [] != 0");
        //    }
        //}
    }
}
