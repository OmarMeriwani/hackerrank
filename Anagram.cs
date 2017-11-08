using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int isAnagram(string s1, string s2)
    {
        int count = 0;
        if (s1.Length != s2.Length)
            return -1;
        for (int i = 0 ; i < s1.Length; i++)
        {
            for (int j = 0 ; j < s1.Length; j++)
            {
                if (s1[i] == s2[j])
                    break;
                if (j == s1.Length - 1 && s1[i] != s2[j])
                    count++;
            }  
        }
        return count;
    }
    
    static int anagaram(string s){
        if (s.Length % 2 == 1)
            return -1;
        string s1 = s.Substring(0, (s.Length / 2));
        string s2 = s.Substring((s.Length / 2) , (s.Length / 2));
        Console.WriteLine(String.Concat(s1.OrderBy(cc => cc)));
        Console.WriteLine(String.Concat(s2.OrderBy(cc => cc)));
        int c = isAnagram(s1, s2); //O(2n)
        return c;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = anagaram(s);
            Console.WriteLine(result);
        }
    }
}
