using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            var sum = 0;
            for (var i = 1; i < value; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum;
        }
    }
}
