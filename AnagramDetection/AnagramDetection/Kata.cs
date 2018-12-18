using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramDetection
{
    public static class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            var lowerTest = test.ToLower().OrderBy(c => c);
            var lowerOriginal = original.ToLower().OrderBy(c => c);
            return lowerTest.SequenceEqual(lowerOriginal);
        }
    }
}
