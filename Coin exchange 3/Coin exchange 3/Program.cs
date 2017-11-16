using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_exchange_2
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
                if (a1[i] == 0 || i == a1.Length - 1)
                {
                    break;
                }
                i++;
            }
            int counter = 0;
            for (int j = a2Start + 1; j < N && counter < a2.Length; j++)
            {
                c[j] = a2[counter];
                counter++;
            }
            return c;
        }
        static int[] getPaths(int b,  int m, int[] C)
        {
            int[] path = new int[m];
            if (b < 0 )
            {
                return null;
            }
            int sum = 0;
            int j = 0;
            while (sum < m)
            {
                sum += C[b];
                path[j] = C[b];
                j++;
                if (sum + C[b] > m)
                {
                    break;
                }
            }
            //Creating path of the possible combination
            if (sum == m)
            {
                return path;
            }
            else if (sum < m)
            {
                int[] p = null;
                while (p == null)
                {
                    b = b - 1;
                    int[] path2 = getPaths(b, m - sum, C);
                    if (path2 != null)
                    {
                        p = joinArrays(path, path2, m);
                    }
                }
                return p;
            }
            else
            {
                return null;
            }
        }
        static void Main(string[] args)
        {
            string a = "";

            int n = 3;//The number of the change types
            int m = 4;//What we want to find
            int[] C = { 1 ,2 ,3 };
            List<int[]> paths = new List<int[]>();
                for (int b = C.Length - 1; b >= 0; b--)
                {
                    int[] result = getPaths(b,  m, C);
                    if (result != null)
                        paths.Add(result);
                    //Else the iteration will end to start trying with new number
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

