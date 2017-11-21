using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        string[] width_temp = Console.ReadLine().Split(' ');
        int[] width = Array.ConvertAll(width_temp, Int32.Parse);
        int[] results = new int[t];
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int min = int.MaxValue;
            for (int k = i; k <= j; k++)
            {
                if (width[k] < min)
                {
                    min = width[k];
                }
            }
            results[a0] = min;
        }
        for (int a0 = 0; a0 < t; a0++)
        {
            Console.WriteLine(results[a0]);
        }
        Console.ReadLine();
    }
}
