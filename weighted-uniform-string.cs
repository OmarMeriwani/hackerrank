using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int letterValue (char a)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < letters.Length; i++)
        {
            if (a == letters[i])
                return i+1;
        }
        return 0;
    }
    static int CalculateW (string s)
    {
        int sum = 0;
        foreach (char a in s.ToCharArray())
        {
            sum += letterValue(a);
        }
        return sum;
    }
    public struct pairs
    {
        public pairs(int intValue, string strValue)
        {
            val = intValue;
            key = strValue;
        }

        public int val { get; private set; }
        public string key { get; private set; }
        
    }
    static int CharWeight(char a)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";
        char[] lle  = letters.ToCharArray();
        int w = 0;
        for (int i = 0 ; i < lle.Length; i++ )
        {
            if (lle[i] == a)
                w = i + 1;
        }
        return w;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());
        bool[] res = new bool[10000000];
        int last = 1;
        string chunk = s[0].ToString();
        char prev = '1';
        int mul = 1;
        for (int i = 0 ; i < s.Length; i++)
        {
            int w = CharWeight(s[i]);
            if (s[i] == prev)
            {
                mul += 1;
                w = w * mul;
            }
            else
            {
                mul = 1;
            }
            prev = s[i];
            res[w] = true;
            
        }
        /*while (last < s.Length) //O(n)
        {
            //Console.WriteLine(s[last] + " index:" + last);
            if (s[last] == s[last -1])
            {
                chunk += s[last];
                pairs p = new pairs(CalculateW(chunk), chunk);//O(m)
                res.Add(p);
               // Console.WriteLine(chunk + " Value:" + CalculateW(chunk));
            }
            else
            {
                pairs p = new pairs(CalculateW(chunk), chunk);
                res.Add(p);
                //Console.WriteLine(chunk + " Value:" + CalculateW(chunk));
                chunk = "";
                chunk += s[last];
                //if (last + 1 == s.Length)
                {
                    pairs p2 = new pairs(CalculateW(chunk), chunk);
                    res.Add(p2);
                    //Console.WriteLine(chunk + " Value:" + CalculateW(chunk));
                }
            }
            
            last ++;
        }*/
        for(int a0 = 0; a0 < n; a0++){
            int x = Convert.ToInt32(Console.ReadLine());
           
            bool res2 = res[x];
            
            /*foreach (pairs pp in res)
            {
                if (pp.val == x)
                {
                    res2 = true;
                    break;
                }
            }*/
            if (res2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
