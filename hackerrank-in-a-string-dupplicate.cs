using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static List<char> findDuplicates (string s)
    {
        List<char> res = new List<char>();
        char[] arr = s.ToCharArray();
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i-1])
                res.Add(arr[i]);
        }
        return res;
    }
    static string RemoveDuplicates(string s, List<char> orgdup)
    {
        int c = 1;
        char[] arr = s.ToCharArray();
        string res = "";
        res += s[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i-1] )
            {
                if (orgdup.Contains(arr[i]) == true)
                    res += new string (new char[] {arr[i] , arr[i]});
                else
                    res += arr[i];
            }
        }
        return res;
    }
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string hh = "hackerrank";
            List<char> orgdup = findDuplicates(s);
            string newc = RemoveDuplicates(s, orgdup);
            Console.WriteLine(newc);
            
        }
    }
}
