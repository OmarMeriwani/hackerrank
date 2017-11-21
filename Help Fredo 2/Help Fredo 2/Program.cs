using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help_Fredo_2
{
    class Program
    {
        private static int N = 0;
        private static double[] A;
        private static string[] Line1;
        static void Main(string[] args)
        {
            N = Convert.ToInt32(Console.ReadLine());
            A = new double[N];
            Line1 = Console.ReadLine().Split(' ');
            A = Array.ConvertAll(Line1, double.Parse);
            double OriginalProduct = Product(A);
            int X = 0;
            for (int i = 10000; i >= 0; i--)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[j] = i;
                }
                double TestProduct = Product(A);
                if (TestProduct < OriginalProduct)
                {
                    X = i + 1;
                    break;
                }
            }
            Console.WriteLine(X);
            Console.ReadLine();
        }
        static double Product(double[] Numbers)
        {
            double P = 1;
            for (int i = 0; i < Numbers.Length; i++)
            { P = P * Numbers[i]; }
            return P;
        }
    }
}
