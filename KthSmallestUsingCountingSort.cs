using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
     class KthSmallestUsingCountingSort
    {
        static int findKthSmallest(int[] arr,
                           int n, int k)
        {
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            int[] counter = new int[max + 1];

            int smallest = 0;

            for (int i = 0; i < n; i++)
            {
                counter[arr[i]]++;
            }

            for (int i = 0;
                     i <= max; i++)
            {

                if (counter[i] > 0)
                {

                    smallest++;
                }

                if (smallest == k)
                {

                    return i;
                }
            }
            return -1;
        }


        //public static void Main(String[] args)
        //{

        //    int[] arr = {7, 10,4,3,20,15};
        //    int N = arr.Length;
        //    int K = 3;

        //    Console.Write(findKthSmallest(arr,N, K));
        //}
    }
}

