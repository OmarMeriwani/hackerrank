using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    class astronaut
    {
        public int astronautt;
        public int country;
        public bool pair;
    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] temp_a = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(temp_a[0]);
        int p = Convert.ToInt32(temp_a[1]);
        List<astronaut> astronts = new List<astronaut>();
        int country = 0;
        for (int i = 0; i < p; i++)
        {
            string input = Console.ReadLine();
            
            string[] arr = input.Split(' ');
            int[] Pair = Array.ConvertAll(arr, int.Parse);
            astronaut exist = astronts.Find(a => a.astronautt == Pair[0]);
            astronaut exist2 = astronts.Find(a => a.astronautt == Pair[1]);
            if (exist == null && exist2 == null)
            {
                country = i;
            }
            else
            {
                country = exist.country;
            }
            astronaut ss = new astronaut();
            ss.astronautt = Pair[0];
            ss.country = country;
            if (exist == null)
            {
                astronts.Add(ss);
            }
            astronaut ss2 = new astronaut();
            ss2.astronautt = Pair[1];
            ss2.country = country;
            if (exist2 == null)
            {
                astronts.Add(ss2);
            }
         }
        if (n > astronts.Count)
        {
            for (int i = 0; i < n; i++)
            {
                if (i < n)
                {
                    astronaut exist = astronts.Find(a => a.astronautt == i);
                    if (exist == null)
                    {
                        country++;
                        astronaut ss = new astronaut();
                        ss.astronautt = i;
                        ss.country = country;
                        astronts.Add(ss);
                    }
                }
            }
        }
        int sumPairs = 0;
        List<astronaut> sorted = astronts.OrderBy(a => a.astronautt).ToList();
        for (int i = 0; i < sorted.Count; i ++ )
        {
            for (int j = i; j < sorted.Count; j++)
            {
                if (sorted[i].country != sorted[j].country)
                {
                    sumPairs += 1;
                }
            }
        }
        Console.WriteLine(sumPairs);
        Console.ReadLine();
    }
}