using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    public static class Kata
    {
        public static List<int> PascalsTriangle(int n)
        {
            var result = new List<int>();
            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j <= i; j++)
                {
                    result.Add(C(i, j));
                }
            }
            return result;
        }
        public static int C(int n, int m)
        {
            int sum = 1;
            for (var i = 1; i <= m; i++)
            {
                sum = sum * (n - m + i) / i;
            }
            return sum;
        }
    }
}
