using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestRank
{
    public class Kata
    {
        public static int HighestRank(int[] arr)
        {            
            return arr.GroupBy(x => x).OrderBy(x => x.Count()).ThenBy(x => x.Key).Last().Key;
        }
    }
}
