using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    public class Sum
    {
        public int GetSum(int a, int b)
        {

            var array = CreateArray(a, b);
            var result = array.Sum();
            return result;

        }

        private int[] CreateArray(int a, int b)
        {
            if (a > b)
            {
                return Enumerable.Range(b, a - b + 1).ToArray();
            }
            else
            {
                return Enumerable.Range(a, b - a + 1).ToArray();
            }
        }
    }
}
