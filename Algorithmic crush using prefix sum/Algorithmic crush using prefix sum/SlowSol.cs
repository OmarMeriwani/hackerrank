using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Mainnnn(String[] args)
    {
        string[] temp1 = (Console.ReadLine().Split(' '));
        Int64 n = Convert.ToInt64(temp1[0]);
        Int64 m = Convert.ToInt64(temp1[1]);
        List<Int64[]> nn = new List<Int64[]>();
        /*StreamReader sr = new StreamReader(@"C:\Users\Omar\AppData\Local\Temporary Projects\Algorithmic crush\Input6.txt");
        string line = "";
        while (  (line = sr.ReadLine()) != null)
        {
            Int64[] a = new Int64[n];
            a = Array.ConvertAll(line.Split(' '), Int64.Parse);
            nn.Add(a);
        }*/
        for (Int64 i = 0; i < m; i++)
        {
            Int64[] a = new Int64[n];
            a = Array.ConvertAll(Console.ReadLine().Split(' '), Int64.Parse);
            nn.Add(a);
        }
        Int64[] results = new Int64[n];
        foreach (Int64[] nnn in nn)
        {
            Int64 min = nnn[0];
            Int64 max = nnn[1];
            for (Int64 i = min - 1; i <= max - 1; i++)
            {
                results[i] += nnn[2];
            }
        }
        Console.WriteLine(findMax(results));

    }
    static Int64 findMax(Int64[] a)
    {
        Int64 max = Int64.MinValue;
        for (Int64 i = 0; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        return max;
    }
}