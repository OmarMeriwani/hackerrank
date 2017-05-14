using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int temp = 0;
        temp = findDifference(a, b);
        Console.WriteLine(temp);

    }
    static int findDifference(string a, string b)
    {
        a = a.ToLower();
        b = b.ToLower();
        bool ex1 = false;
        string temp = "";
        for (char c = 'a'; c <= 'z'; c++)
        {
            for (int i = 0; i < Math.Min(HowManyTimes(c, a), HowManyTimes(c, b)); i++)
                temp += c;
        }
        return ((a.Length - temp.Length) + (b.Length - temp.Length));
    }
    static int HowManyTimes(char c, string a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
            if (a[i] == c)
                sum++;

        return sum;
    }
}
