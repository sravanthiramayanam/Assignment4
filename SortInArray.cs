using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
     class SortInArray
    {
        public static void sortArray(int []arr, int n)
        {
            int count0 = 0, count1 = 0, count2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0) count0++;
                else if (arr[i] == 1) count1++;
                else if (arr[i] == 2) count2++;
            }

            for (int i = 0; i < n; i++)
            {
                if (count0 > 0)
                {
                    arr[i] = 0;
                    count0--;
                }
                else if (count1 > 0)
                {
                    arr[i] = 1;
                    count1--;
                }
                else if (count2 > 0)
                {
                    arr[i] = 2;
                    count2--;
                }
            }

        }
        public static void Main(string[] args)
        {
           
            int[] arr = { 0,1,2,0,1,2 };
            int n = arr.Length;

            sortArray(arr, n);
           
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            //Timecomplexity:O(n)
            //spacecomplexity:O(1)
        }

    }
}
