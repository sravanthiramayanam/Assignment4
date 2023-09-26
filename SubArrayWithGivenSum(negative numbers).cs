using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
     class SubArrayWithGivenSum_negative_numbers_
    {
        public static int subArraySum(int[] arr, int n,
                                   int sum)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int currentsum = 0;
            for (int i = 0; i < n; i++)
            {
                currentsum=currentsum+arr[i];
                dict[currentsum] = i;
                if(currentsum > sum)
                {
                    if (dict.ContainsKey(currentsum - sum))
                    {
                        Console.WriteLine("Sum found between" + "indexes" + dict[currentsum - sum] + " and " + i);
                        return 1;
                    }
                }
                if (currentsum == sum)
                {
                    Console.WriteLine("Sum found between" + "indexes" + 0 + " and " + i);
                    return 1;
                }
            }

            Console.WriteLine("No subarray found");
            return 0;
        }

        //public static void Main(string[] args)
        //{
        //    int[] arr = new int[] {10,2,-2,-20,10};
        //    int n = arr.Length;
        //    int sum = -10;

        //    // Function call
        //    subArraySum(arr, n, sum);
        //}
    }
}//Time complexity:O(n)
 //space complexity:O(n)
