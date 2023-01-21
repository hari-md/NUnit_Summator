using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static int Sum(int[] arr) //Sum is the Methed that we created. It can bbe tested with another program from the dev.
        {
            int sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static void Test_SumTwoNumbers()
        {
            if (Sum(new int[] { 1, 2 }) != 3)
            {
                throw new Exception("1+2 != 3");
            }
            else
            {
                Console.WriteLine("Test pass!");
            }

            // Calls method Sum and trows back an NEW exception if 1+2 !=3;
        }

        public static void Test_SumEmptyArray()
        {
            if (Sum(new int[] { }) != 0)
            {
                throw new Exception("sum [] != 0");
            }
        }
    }
}
