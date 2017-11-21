using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp, Int32.Parse);
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int NextMin = FindNextMin(i, A, n, min);
            if (NextMin < min && NextMin != -1)
            {
                min = NextMin;
            }
        }
        if (min == int.MaxValue)
        {
            min = -1;
        }
        Console.WriteLine(min);
        Console.ReadLine();
    }
    public static  int FindNextMin(int i, int[] A, int n, int LastMinDistance)
    {
        int j = -1;
        for (int ii = i + 1; ii < n; ii++)
        {
            if (A[ii] == A[i])
            {
                if (Math.Abs(ii - i) < LastMinDistance)
                {
                    j = Math.Abs(ii - i);
                    break;
                }
                else
                {
                    j = LastMinDistance;
                }
            }
        }
        return j;
    }
}
