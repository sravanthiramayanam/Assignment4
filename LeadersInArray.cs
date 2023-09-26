using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class LeadersInArray
    {
        static void printLeaders(int[] arr, int size)
        {
            int maxelement_from_right = arr[size - 1];

            // Rightmost element is always leader
            Console.Write(maxelement_from_right + " ");

            for (int i = size - 2; i >= 0; i--)
            {
                if (maxelement_from_right < arr[i])
                {
                    maxelement_from_right = arr[i];
                    Console.Write(maxelement_from_right + " ");
                }
            }
            //return 1;
        }

       
        public static void Main(String[] args)
        {
           // LeadersInArray lead = new LeadersInArray();
            int[] arr = new int[] { 16, 17, 4, 3, 5, 2 };
            int n = arr.Length;
            printLeaders(arr, n);
           // Time O(n)
           //space O(1)/
           // lead.printLeaders(arr, n);
        }
    }
}
