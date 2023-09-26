using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class DecreasingFrequency
    {
       static void GetDecreasingFrequency(int[] arr)
       {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(var num in arr)
            {
                if(!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                    dict[num]++;
            }
            var dictSorted = dict.OrderByDescending(key => key.Value);
            foreach(var keyvaluepair in dictSorted)
            {
                var count=keyvaluepair.Value;
                while(count>0)
                {
                    Console.Write(keyvaluepair.Key +" ");
                    count--;
                }
            }
        }
        //public static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 2, 5, 2, 8, 5, 6, 8, 8 };
        //    GetDecreasingFrequency(arr);
        //}

    }
}
