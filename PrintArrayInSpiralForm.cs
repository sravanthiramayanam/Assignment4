using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment4
{
    class PrintArrayInSpiralForm
    {
        public static void SpiralOrder(int[,] matrix)
        {
            int left = 0, right = matrix.GetLength(0);
            int top=0, bottom = matrix.GetLength(1);

            while(left < right && top < bottom)
            {
                for(int i = left; i < right; i++)
                {
                   Console.Write(matrix[top,i]+" ");
                }
                top++;
                for (int i = top; i < bottom; i++)
                {
                    Console.Write(matrix[i,right-1] + " ");
                }
                right--;
                for (int i = right-1; i > left; i--)
                {
                    Console.Write(matrix[bottom-1,i] + " ");
                }
                bottom--;
                for (int i = bottom; i >top-1; i--)
                {
                    Console.Write(matrix[i,left] + " ");
                }
                left++;
            }
        }

        //public static void Main(string[] args)
        //{
        //    int[,] a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, {13,14,15,16 } };
        //    SpiralOrder(a);
        //}

    }
}
