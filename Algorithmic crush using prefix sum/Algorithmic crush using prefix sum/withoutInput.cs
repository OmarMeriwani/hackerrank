using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithmic_crush_using_prefix_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp1 = (Console.ReadLine().Split(' '));
            Int64 n = Convert.ToInt64(temp1[0]);
            Int64 m = Convert.ToInt64(temp1[1]);
            Int64[] resultArr = new Int64[n];



            for (Int64 i = 0; i < m; i++)
            {
                Int64[] a = new Int64[3];
                a = Array.ConvertAll(Console.ReadLine().Split(' '), Int64.Parse);
                resultArr[a[0] - 1] += a[2];
                if ((a[1]) < n)
                    resultArr[a[1]] -= a[2];
            }
            Int64 max = resultArr[0];
            Int64 sum = resultArr[0];
            for (int i = 1; i < n; i++)
            {
                sum += resultArr[i];
                if (max < sum)
                    max = sum;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
