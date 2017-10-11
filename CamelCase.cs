using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        char[] ss = s.ToCharArray();
        int counter = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (Char.IsUpper(ss[i]))
                counter ++;
        }
        Console.WriteLine(counter);
    }
}
