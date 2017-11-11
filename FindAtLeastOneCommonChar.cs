using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string twoStrings(string s1, string s2){
        // Complete this function
        if(FindAtLeastOneCommonChar(s1, s2).Length > 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
     static string FindAtLeastOneCommonChar(string s1, string s2)
    {
        Char[] s2c = s2.ToCharArray();
        string common = "";
        Char[]  allLetters =  "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        foreach (char c in allLetters)
        {
            if (s1.IndexOf(c) > -1 && s2.IndexOf(c) > -1)
                return "aa";
        }
       
        return common;
    }
  
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string result = twoStrings(s1, s2);
            Console.WriteLine(result);
        }
    }
}
