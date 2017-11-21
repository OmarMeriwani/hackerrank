using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
    static int[] Shift1s(int k, int[] a, int n)
    {
        int[] b = new int[n];
        b = a;
        while (k > 0)
        {
            int temp = a[0];
            for (int i = 0; i < n - 1; i++)
            {
                int end = i + 1;
                b[i] = b[end];
            }
            a[n - 1] = temp;
            k--;
        }
        return b;
    }
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        a = Shift1s(k, a, n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}
