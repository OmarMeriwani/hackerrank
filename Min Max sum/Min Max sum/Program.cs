using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Min_Max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp_arr = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(temp_arr, int.Parse);
            Int64[] Sum = new Int64[arr.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                    {
                        Sum[count] += arr[j];
                    }
                }
                count++;
            }
            Int64 Max = 0;
            Int64 Min = Int64.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Sum[i] > Max)
                {
                    Max = Sum[i];
                }
                if (Sum[i] < Min)
                {
                    Min = Sum[i];
                }
            }
            Console.WriteLine(Min + " " + Max);
            Console.ReadLine();
        }
    }
}
