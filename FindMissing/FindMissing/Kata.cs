using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissing
{
    public class Kata
    {
        public static int FindMissing(List<int> list)
        {
            var difference = (list.Last() - list.First()) / list.Count;
            int i;
            for(i = 0; i < list.Count - 1; i++)
                if (list[i + 1] - list[i] != difference)
                    break;
            return list[i] + difference;
        }
        static void Main(string[] args)
        {
        }
    }
}
