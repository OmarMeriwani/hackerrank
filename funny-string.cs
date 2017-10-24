using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string funnyString(string s){
        // Complete this function
        string r = reverseS(s);
        for (int i = 1 ; i < s.Length; i++)
        {
            if (difference(s[i], s[i - 1]) != difference(r[i], r[i-1]))
            {
                return "Not Funny";
            }
        }
        return "Funny";
    }
    static int difference (char c1, char c2)
    {
        return Math.Abs(getIndex(c1) - getIndex(c2));
    }
    static int getIndex(char c)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";
        return letters.IndexOf(c);
    }
    static string reverseS(string s)
    {
        string res = "";
        for (int i = s.Length - 1 ; i >= 0; i-- )
        {
            res += s[i];
        }
        return res;
    }
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string result = funnyString(s);
            Console.WriteLine(result);
        }
    }
}
