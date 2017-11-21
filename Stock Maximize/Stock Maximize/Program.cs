using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        int balance = 0;
        int[] results = new int[t];
        for (int a0 = 0; a0 < t; a0++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] prices_temp = Console.ReadLine().Split(' ');
            int[] prices = Array.ConvertAll(prices_temp, Int32.Parse);
            int profit = 0;
            int max = 0;
            for (int i = 1; i < N; i++)
            {
                if (max < prices[i])
                    max = prices[i];
            }
            for (int i = 0 )
            
        }
        for (int i = 0; i < t; i++)
        {
            Console.WriteLine(results[i]);
        }
        Console.ReadLine();
    }
}
