using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int minSteps(int n, string s){
            int count = 0;
        for (int i = 2; i < n; i += 1)
        {
            string test = new string (new char[]{ s[i-2], s[i-1], s[i] });
            //Console.WriteLine(test);
            if (test == "010")
            {
                count++;
                char[] m = s.ToCharArray();
                m[i] = '1';
                s = new string(m);
            }
        }
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string B = Console.ReadLine();
        int result = minSteps(n, B);
        Console.WriteLine(result);
    }
}
