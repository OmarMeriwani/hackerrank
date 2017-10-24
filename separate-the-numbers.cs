using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
                    /*
                    Works for all cases except this
                    1
                    96589218797811259658921879781126
                    */
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int m = 1;
            bool  seq = false;
            string First = "";
            while (m <= s.Length / 2)
            {
                int end = m;
                int tempM = m;
                //Console.WriteLine("end ("+ end +") < s.Length ("+ s.Length +") && tempM = " + tempM);
                while (end < s.Length  && tempM + end  <= s.Length )
                {
                    double n1 =0;
                    double n2 =0;
                    string num1 = s.Substring(end - m, m);
                    if (First == "")
                        First = num1;
                    string num2 = s.Substring(end, tempM);
                    
                    n1 = Convert.ToDouble(num1);
                    n2 = Convert.ToDouble(num2);
                    //Console.WriteLine(n1 + "," + n2);
                    if (n1 + 1 == n2)
                    {
                        end += tempM;
                        m = tempM;
                        seq = true;
                    }
                    else
                    {
                        seq = false;
                        tempM++;
                    }
                }
                if (First[0] == '0' && seq == true)
                {
                    seq = false;
                    break;
                }
                if (end == s.Length  && seq == true)
                        break;
                m++;
                First = "";
            }
            if (seq == true)
            {
                Console.WriteLine("YES " + First);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
