using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSum
{
    public static class Kata
    {
        public static int LargestSum(int[] arr)
        {
            var maxSum = 0;
            var sum = 0;

            foreach (var item in arr)
            {
                sum += item;
                if (sum <= 0)
                    sum = 0;
                if (sum > maxSum)
                    maxSum = sum;
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
        }
    }
}
