using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comparators_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toBeChecked = { 1,3,5,2,9,7,2,1,10};
            //1,3 | 5,2 | 9,7 | 2,1 | 10
            //1,3 | 2,5 | 7,9 | 1,2 | 10
            //1,2 | 3,5 | 7,1 | 9,2 | 10
            //1,2 | 3,5 | 1,7 | 2,9 | 10
            //1,2 | 3,5 | 1
        }
        static int[] plusComparator(int[] a)
        {
            int[] result = new int[2];
            if (a[0] > a[1])
            {
                result[0] = a[1];
                result[1] = a[0];
            }
            else
            {
                result[0] = a[0];
                result[1] = a[1];
            }
            return result;
        }
    }
}
