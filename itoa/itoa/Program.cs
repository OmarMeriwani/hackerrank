using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itoa
{
    class Program
    {

        static void Main(string[] args)
        {
            result = convert(354000780);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static string result = string.Empty;

        public static String convert(int x)
        {
            bool neg = false;
            String s = "";
            if (x == 0)
                return "0";
            neg = (x < 0);
            if (neg)
                x = -1 * x;
            while (x != 0)
            {
                s = (x % 10) + s;
                x = x / 10;
            }
            if (neg)
                s = "-" + s;
            return s;
        }
    }
}
