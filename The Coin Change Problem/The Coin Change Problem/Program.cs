using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long getWays(Int64[] c, int n, int m)
    {
        long[] table = new long[m+1];
        table[0] = 1;
        for (int i=0; i<n; i++)
            for (long j=c[i]; j<=m; j++)
                table[j] += table[j-c[i]];
        return table[m];
    }


    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_n[0]);
        int n = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        long[] c = Array.ConvertAll(c_temp, Int64.Parse);
        // Print the number of ways of making change for 'n' units using coins having the values given by 'c'
        long ways = getWays(c, n, m);
        Console.WriteLine(ways);
        Console.ReadLine();
    }
}
