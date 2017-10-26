using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int gemstones(string[] arr){
        // Complete this function
        List<char> rem = new List<char>();  
        string p = "";
        for (int i = 1 ; i < arr.Length; i++)
        {
            string c = arr[i];
            //Console.WriteLine(c);
            p = arr[i - 1];
            //Console.WriteLine(p);
            List<char> rem2 = diff(c,p);
            rem.AddRange(rem2);
            //Console.WriteLine(string.Join(",", rem.ToArray()));

            foreach (char cc in rem)
            {
                c = c.Replace(cc.ToString(),"");
                p = p.Replace(cc.ToString(),"");
            }
            //Console.WriteLine(c);
            //if (i != arr.Length - 1)
                p += c;

            //Console.WriteLine(p);
        }
        p = string.Join("", p.ToCharArray().Distinct());
        return p.Length;
    }
    /*static string removeDuplicates(string s)
    {
        string res = "";
        Dictionary<string, bool> k = new Dictionary<string, bool>();
        
        for (int i = 0; i < s.Length; i++)
        {
               
        }
    }*/
    static List<char> diff(string s1, string s2)
    {
        List<char> rem = new List<char>();
        foreach (char a in s2.ToCharArray())
        {
            if (s1.Contains(a) == false)
            {
                rem.Add(a);
            }
        }
        foreach (char a in s1.ToCharArray())
        {
            if (s2.Contains(a) == false)
            {
                rem.Add(a);
            }
        }
        //Console.WriteLine(string.Join( ",", rem.ToArray() ));
        return rem;
    }
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for(int arr_i = 0; arr_i < n; arr_i++){
           arr[arr_i] = Console.ReadLine();   
        }
        int result = gemstones(arr);
        Console.WriteLine(result);
    }
}
