using System;
using System.Collections.Generic;

namespace WholeSquareCount
{
    public class Solution
    {
        public int[] solution(int a, int b)
        {
            var result = new List<int>();
            if (!(a < 0 && b < 0))
            {
                var start = PreventNegative(a);
                var end = PreventNegative(b);
                for (int i = start; i <= end; i++)
                {
                    var root = Math.Sqrt(i);
                    if (root % 1 == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result.ToArray();
        }

        private int PreventNegative(int value)
        {
            return value > 0 ? value : 0;
        }
    }
}
