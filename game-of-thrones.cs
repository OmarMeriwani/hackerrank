using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static string findDistinct(string s)
    {
        string temp = s;
        string dist = "";
        for (int i = 0 ; i < s.Length; i++)
        {
            if (dist.Contains(temp[i].ToString()) == true)
            {
                dist += s[i];
                temp  = temp.Replace(s[i].ToString(),"");
            }
        }
        return dist;
    }
    static string gameOfThrones(string s){
        // find distinct
        string dist = findDistinct(s);
        //find if each character exist at even number of times
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (int i  = 0 ; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i].ToString()) == true)
            {
                int val = dic[s[i].ToString()];
                val ++;
                dic[s[i].ToString()] = val;
            }
            else
            {
                dic.Add(s[i].ToString(), 1);
            }
        }
        int numOfOdds = 0;
        foreach (KeyValuePair<string, int> kv in dic)
        {
            if (kv.Value % 2 == 1)
            {
                numOfOdds++;
            }
            if (numOfOdds > 1)
            {
                return "NO";
            }
        }
        return "YES";
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = gameOfThrones(s);
        Console.WriteLine(result);
    }
}
