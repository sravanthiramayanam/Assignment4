//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace SubarrayWithGivenSum
//{
//    class SubArrayWithGivenSum
//    {
//        public static int SubArraySum(int[] a, int num)
//        {
//            int sum = 0, start = 0, end = 0;
//            if (a.Length == 0)
//                return 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (sum < num)
//                {
//                    sum += a[end];
//                    end = i + 1;
//                }
//                if (sum > num)
//                {
//                    sum -= a[start];
//                    start++;

//                }
//                if (sum == num)
//                {
//                    int p = end - 1;
//                    Console.WriteLine("Sum found between" + "indexes" + start + " and " + p);
//                    return 1;
//                }


//            }

//            Console.WriteLine("No subarray found");
//            return 0;
//        }
//        public static void Main(string[] args)
//        {
//            int[] a = { 1, 4, 20, 3, 10, 5 };
//            int num = 33;
//            SubArraySum(a, num);

//        }
//        //time complexity:O(n)
//        //space complexity:O(1)

//    }
//}
