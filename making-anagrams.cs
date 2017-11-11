using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int makingAnagrams(string s1, string s2){
        // Complete this function
        string c = findCommoWithDuplicates(s1,s2);
        //Console.WriteLine(c);
        return s1.Length + s2.Length - (c.Length * 2);
    }
    static string findCommoWithDuplicates(string s1, string s2)
    {
        string common = "";
        for (int i = 0 ; i < s1.Length; i++) //O(n)
            for (int j = 0 ; j < s2.Length; j++) // O(m)
            {
                if (s1[i] == s2[j])
                {
                    common += s1[i];
                    char[] s2c = s2.ToCharArray(); //O(n)
                    s2c[j] = '\0';
                    s2 = new string(s2c); 
                    break;
                }
                if (j == s2.Length - 1 && s1[i] != s2[j])
                {
                    char[] s1c = s1.ToCharArray(); //O(m)
                    s1c[i] = '\0';
                    s1 = new string(s1c);
                }
            }
        return common;
    }
    static void Main(String[] args) {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        Console.WriteLine(result);
    }
}
