using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 9, 8, 9 } };           

            int i = 0;
            int j = 0;
            int sum1 = 0;
            while (i < 3 && j < 3)
            {
                //Console.WriteLine(arr[i, j]);
                sum1 += arr[i, j];
                i++;
                j++;
            }

            i = 0;
            j = 2;
            int sum2 = 0;
            while (i < 3 && j >= 0)
            {
                //Console.WriteLine(arr[ii, jj]);
                sum2 += arr[i, j];
                i++;
                j--;
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine ("resultado: " + Math.Abs(sum2 - sum1));

            List<int> lista = new List<int>();
            List<List<int>> arr2 = new List<List<int>>();
            var d = arr2[0][0];
        }
    }
}
