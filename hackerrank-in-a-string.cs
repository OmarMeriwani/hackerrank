using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string hh = "hackerrank";
            char[] arr = hh.ToCharArray();\\1
            char[] sar = s.ToCharArray();\\n
            string res = "";
                int last = 0;
            foreach (char a in hh) \\1
            {
                while (last < sar.Length)\\n
                {
                    if (sar[last] == a)\\1
                    {
                        res += a;
                        last++;
                        break;
                    }
                    else
                    {
                        last++;
                        continue;
                    }
                }
            }
            //Console.WriteLine(res);
            if (res == hh)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            
        }
    }
}
