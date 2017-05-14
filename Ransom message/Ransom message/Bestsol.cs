using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Bestsol
{

    static void Main(String[] args)
    {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        var inter = magazine.Intersect(ransom);
        if (inter.Count() == ransom.Length)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
