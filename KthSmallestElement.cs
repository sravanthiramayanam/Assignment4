using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Assignment4
{
    class KthSmallestElement
    {
        public static int KthSmallest(int[] a, int k, int left, int right)
        {
            Console.WriteLine("recursion: K " + k + " left " + left + " right " + right);
            int pivot = a[right], position = left, temp = 0;
            for (int i = left; i <= right - 1; i++)
            {
                if (a[i] <= pivot)
                {
                    temp = a[position];
                    a[position] = a[i];
                    a[i] = temp;
                    position++;

                }




            }
            temp = a[position];
            a[position] = a[right];
            a[right] = temp;

            Console.WriteLine("b4 recursion: position " + position + " left " + left + " right " + right);
            if (position - left == k - 1)
                return a[position];
            if (position - left > k - 1)
                return KthSmallest(a, k, left, position - 1);

            return KthSmallest(a, k - position + left - 1, position + 1, right);



        }
        //public static void Main(String[] args)
        //{
        //    int[] a = { 7, 10, 4, 3, 20, 15 };
        //    int k = 4, left = 0, right = 5;
        //    Console.WriteLine(KthSmallest(a, k, left, right));
        //}
    }
}
