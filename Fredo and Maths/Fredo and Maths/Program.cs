using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fredo_and_Maths
{
    class Program
    {
        private static int x = 0;
        private static Int64 k = 0;
        private static Int64 m = 0;
        private static int T = 0;
        private static string[] Line1;
        private static Int64[] results;
        static void Main(string[] args)
        {
            T = Convert.ToInt32(Console.ReadLine());
            //if ((T > 100000 || T < 1))
            //{
            //    //Console.WriteLine(T);
            //    Environment.Exit(0);
            //}
            results = new Int64[T];
            for (int i = 0; i < T; i++)
            {
                Line1 = Console.ReadLine().Split(' ');
                Int64[] A = Array.ConvertAll(Line1, Int64.Parse);
                x = Convert.ToInt16(A[0]);
                k = A[1];
                m = A[2];
                //if (m > 10000000 || m < 1 || k > 1000000000000000000 || k < 1 || IsPrime(x) == false )
                //{
                //    //Console.WriteLine(m + " "+ k + " " + m  );
                //    Environment.Exit(0);
                //}
                results[i] = Algo(x,k,m);
            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(results[i]);
            }
            Console.ReadLine();
        }
        public static Int64 Algo(Int64 x, Int64 k, Int64 m)
        {
            Int64 n = 0 ;
            n = Power(x, k) % m;
            return n;
        }
        public static Int64 Power(Int64 number, Int64 pow)
        {
            Int64 n = number ;
            //n = Convert.ToInt64(Math.Pow(Convert.ToDouble(number), Convert.ToDouble(pow)));
            for (Int64 i = 0; i < pow && i > 0; i++)
            {
                n = n * number;
            }
            return n;
        }
        static bool IsPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0).SequenceEqual(new[] { 1, n });
            }

            return false;
        }


    }

}
