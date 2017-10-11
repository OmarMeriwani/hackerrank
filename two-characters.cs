using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string SelectDistinct (string original) // O(n)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        for (int i = 0; i < original.Length; i++) // O(n)
        {
            string c = original[i].ToString(); // O(1) -- Ignored
            try
            {
                dic.Add(c,"1");
            }
            catch (Exception ex)
            {
                
            }
        }
        string result = "";
        foreach (KeyValuePair<string, string> k in dic)// O(n)
        {
            result += k.Key;
        }
        return result;
		// O(2n) ~ O(n)
    }
    static bool test(string s)
    {
        for (int i = 1 ; i < s.Length; i++) // O(n)
        {
            if (s[i] == s[i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static string GetOthers(string[] pair, string distinct) // O(n^2)
    {
        string res = distinct; 
        foreach (string s in pair)
        {
            res = res.Replace(s, "");
        }
        return res;
    }
    static string RemoveOthers (string Others, string s) // O(n^2)
    {
        string res = s;
         for (int i = 0 ; i < Others.Length; i++)
        {
            string c = Others[i].ToString();
            res = res.Replace(c,"");
        }
        return res;
    }
    static void Main(String[] args) 
    {
        int len = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        string Distinct = SelectDistinct(s);
        //Console.WriteLine(Distinct);
        int Max = 0;
        //Select Two Characters -- O(D^2 S^2 t) 
        for (int i = 0; i < Distinct.Length; i++)
        {
            for (int j = 0; j < Distinct.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
				//O(D^2)
                string Others = GetOthers(new string[] {Distinct[i].ToString(),Distinct[j].ToString() }, Distinct);
                //Console.WriteLine("Pair:" + Distinct[i] + "," + Distinct[j] + " Others:" + Others);
                //O(S*r)
				string tt = RemoveOthers(Others, s);
                //Console.WriteLine("After remove:" + tt + " from S:" + s);
				// O(t)
                bool b = test(tt);
                //Console.WriteLine(b);
                if (b == true)
                {
                    if (tt.Length > Max)
                    {
                        Max = tt.Length;
                    }
                }/**/
            }
        }
        Console.WriteLine(Max.ToString());
    }
}
