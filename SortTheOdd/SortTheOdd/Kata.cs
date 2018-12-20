using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheOdd
{
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            var oddStack = new Queue(array.Where(x => isOdd(x)).OrderBy(x => x).ToList());
            for(var i = 0; i < array.Length; i++)
                if (isOdd(array[i]))
                    array[i] = (int)oddStack.Dequeue();
            return array;
        }
        private static bool isOdd(int x)
        {
            return x % 2 == 1;
        }
    }
}
