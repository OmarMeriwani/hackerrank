using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect_square
{
    class Program
    {
        static    int[] squares={ 1,4,9,16,25,36,49,64,81,100, 121, 144, 169};
        static void Main(string[] args)
        {
            int n = 33;
            Console.WriteLine(min_cost(n));
            Console.ReadLine();
        }
        static int min_cost(int n)
        {
            if (n <= 0)
                return 0;
            int square = Convert.ToInt32(Math.Sqrt(n));
            int answer = int.MaxValue;
            for (int i  = 0; i <= square; i++)
            {
                int next = n - squares[i];
                int sub = min_cost(next) + 1;
                answer = Math.Min(answer, sub);
            }
            return answer;
        }
    }
}
