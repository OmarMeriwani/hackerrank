using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine(); // 1
        char[] ss = s.ToCharArray(); //n
        int counter = 1; // 1
        for (int i = 1; i < s.Length; i++) // n ()
        {
            if (Char.IsUpper(ss[i])) // 1
                counter ++; // 1
        }
        Console.WriteLine(counter); //Total: 2n
    }
}
