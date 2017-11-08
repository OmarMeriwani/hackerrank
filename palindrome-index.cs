using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static bool IsPalindrome(string s)
    {
        int len = s.Length - 1;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[len - i])
            {
                
                return false;
            }
        }
        return true;
    }
    
    static int palindromeIndex(string s){
        int len = s.Length - 1;
        int index = -1;
        string t = s;
        if (IsPalindrome(s) == true)
            return index;
        for (int i = 0 ; i < s.Length / 2; i++)
        {
           if (s[i] != s[len - i])
           {
               
               index = i;
               t = t.Remove(i,1);
               if (IsPalindrome(t) == true)
               {
                   break;
               }
               else
               {
                   t = s;
                   index = len - i;
                   t = t.Remove(len - i,1);
                   break;
               }
           }
        }
        return index;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = palindromeIndex(s);
            Console.WriteLine(result);
        }
    }
}
