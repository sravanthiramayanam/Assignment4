using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Equilibrium
    {
        static int EquilibriumIndexOfArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i <= a.Length - 1; i++)
                sum += a[i];

            int left = 0, right = 0;
            for (int i = 1; i < a.Length - 1; i++)
            {
                left += a[i - 1];
                right = sum - left - a[i];

                //Console.Write("sum:"+ sum+"i:" + i + "left: " + left + "right: " + right+"\n");
                if (left == right)
                    return i;
            }
           
            return -1;

        }

        public static void Main(string[] args)
        {
            int[] a = {-7,1,5,2,-4,3,0};
            Console.Write("Equilibrium index of Array is "
                          + EquilibriumIndexOfArray(a));
        }
    }
    
}
