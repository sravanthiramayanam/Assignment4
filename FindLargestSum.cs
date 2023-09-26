using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class FindLargestSum
    {
        static int SubArrayLargestSum(int[] a)
        {
            int size = a.Length;
            int maxsum = int.MinValue, sum = 0;
            if(a.Length==0)
                return 0;
            if (a.Length == 1)
                return a[0];

            for (int i = 0; i < size; i++)
            {
                sum = sum + a[i];

                if (maxsum<sum)
                    maxsum = sum;

                if (sum < 0)
                    sum = 0;
            }

            return maxsum;
        }

     
        //public static void Main(string[] args)
        //{
        //    int[] a = { -2,-3,4,-1,-2,1,5,-3 };
        //    Console.Write("Largest contiguous sum is "
        //                  + SubArrayLargestSum(a));
        //}
    }
}
//Time complexity:O(n)
//space complexity:O(1)