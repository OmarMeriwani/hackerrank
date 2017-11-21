using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string input = "1";
            int rectangles = 0;
            int squares = 0;
            int polygons = 0;
            List<int[]> arrays = new List<int[]>();
            while ((input = Console.ReadLine()) != null && input != "")
            {
                if (input == "")
                {
                    break;
                }
                int[] lines = Array.ConvertAll(input.Split(' '), int.Parse);
                int a = lines[0];
                int b = lines[1];
                int c = lines[2];
                int d = lines[3];
                bool IsSquare = false;
                bool isZero = false;
                bool IsRectangle = false;
                if (a <= 0 || b <= 0 || c <= 0 || d <= 0)
                {
                    polygons++;
                    isZero = true;
                }
                if ((a == b) && (b == c) && (c == d) && isZero == false)
                {
                    squares++;
                    IsSquare = true;
                }
                else if (((a == c && d == b)) && (IsSquare == false) && isZero == false)
                {
                    rectangles++;
                    IsRectangle = true;
                }
                else if (IsRectangle == false && isZero == false  && IsSquare == false )
                {
                    polygons++;
                }
            }

          
            Console.WriteLine(squares + " " + rectangles + " " + polygons);
            Console.ReadLine();
        }
        
    }
}