using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_pairs_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[i] + arr[j] == num)
                        Console.WriteLine(i + " - " + j );
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
