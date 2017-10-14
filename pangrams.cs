using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        string s  = Console.ReadLine();
        s = s.ToLower();
        string letters = "abcdefghijklmnopqrstuvwxyz";
        bool res = true;;
        foreach (char letter in letters) //1
        {
            if (s.Contains(letter.ToString()) == false) //O(n)
            {
                res = false;
            }
        }
        if (res == false )
        {
            Console.WriteLine("not pangram");
        }
        else
        {
            Console.WriteLine("pangram");
        }
    }
}
}
