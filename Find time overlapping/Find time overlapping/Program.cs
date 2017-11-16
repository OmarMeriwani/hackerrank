using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            List<int[]> times = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int[] lines = Array.ConvertAll(input, int.Parse );
                times.Add(lines);
            }
            int number = 0;
            for (int i = 0; i < times.Count; i ++ )
            {
                for (int j = i; j < times.Count; j++)
                {
                    int[] aa = times.FindIndex(i);
                    int b = times.FindIndex(i);
                    bool overlap = aa[0] < b[1] && b[0] < aa[1];
                    if (overlap == true)
                        number++;
                }
            }
            Console.WriteLine(number);
        }
    }
}
