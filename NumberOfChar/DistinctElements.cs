using System;
using System.Linq;

namespace NumberOfChar
{
    public class DistinctElements
    {
        public static int CountDistinct(int[] rnum)
        {
            int count = 0;
            for (int i = 0; i < rnum.Length; i++)
            {
                int j = 0;
                for (j = 0; j < i; j++)
                    if (rnum[i] == rnum[j])
                        break;
                if (i == j)
                    count++;
            }
            return count;
        }
    }
}
