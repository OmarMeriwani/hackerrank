using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_change
{
    class Program
    {
        static int[] joinArrays(int[] a1, int[] a2, int N)
        {
            int[] c = new int[N];
            int a2Start = 0;
            int i = 0;
            while (a1[i] != 0)
            {
                a2Start = i;
                c[i] = a1[i];
                if (a1[i] == 0 || i == a1.Length - 1 )
                {
                    break;
                }
                i++;
            }
            int counter = 0;
            for (int j = a2Start + 1; j < N; j++)
            {
                c[j] = a2[counter];
                counter++;
            }
            return c;
        }
        static int[] getPaths(int a, int N)
        {
            List<int[]> paths = new List<int[]>();
            //Create the path object
            int[] path = new int[N];
            int j = 0;
            path[j] = a;
            int sum = a;
            for (int b = 1; b < a && sum + b > N; b++)
            {
                sum += b;
                path[j] = b;
                j++;
            }
               
            if (sum == N)
            {
                return path;
            }
            else if (sum < N)
            {
                a = sum;
                int[] path2 = getPaths(a,  N );
                if (path2 != null)
                    return joinArrays(path, path2, N);
                else
                    return null;
            }
            else
            {
                return null;
            }

        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()); ;

            List<int[]> paths = new List<int[]>();
            for (int a = 1; a < N + 1; a++)
            {
                //Create the path object
                int[] path = new int[N];
                if (a >= N)
                {
                    break;
                }
                //Save the (a) at index (0).
                int j = 0;
                path[j] = a;
                int sum = a;
                //Create paths of different increments
                //for (int b = 1; b < a + 1; b++)
                //{
                    int[] result = getPaths(a, N);
                    if (result != null)
                        paths.Add(result);
                    //Else the iteration will end to start trying with new number
                //}
            }
            foreach (int[] c in paths)
            {
                Console.WriteLine();
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] != 0)
                        Console.Write(c[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
