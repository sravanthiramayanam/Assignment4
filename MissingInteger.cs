using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
     class MissingInteger
    {
        public static int missingInteger(List<int> integerList,int N)
        {
            int Totalsum = 0;
            int ExpectedSum = (N * (N + 1) / 2);
            for(int i=0;i<integerList.Count;i++)
            {
               Totalsum += integerList[i];

            }
            return (ExpectedSum-Totalsum);

        }
        //public static void Main(string[] args)
        //{
        //    List<int> integerlist = new List<int>() {1,2,3,5 };
        //    int N = 5;
        //    int missedinteger = missingInteger(integerlist, N);
        //    Console.Write(missedinteger);
        //}

    }
   // Time Complexity: O(N)
    // Space Complexity: O(1)
}
