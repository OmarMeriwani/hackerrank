using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(input, int.Parse );
            int n = arr.Length;
            List<int> arr2 = new List<int>();
            int previous = arr[0];
            arr2.Add(arr[0]);
            for (int i = 1; i < n ; i++)
            {
                int difference = arr[i] - previous;
                if (Math.Abs(difference) > 127)
                {
                    arr2.Add( -128);
                }
                arr2.Add(difference);
                previous = arr[i];
            }
            foreach (int a in arr2)
            {
                Console.Write(a + " ");
            }
            Console.ReadLine();
        }
    }
}
