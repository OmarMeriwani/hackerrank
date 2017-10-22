using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            //Start a loop for 1 characters that starts from 1, because 0 will be saved in the first time.
            //if the loop fails then start with two characters..
            //inside the loop compare the m characters with the previous m characters, if you reach the end of the string then break
            //...increase the number of characters until loop size will be larger than n / 2.. ANOTHER LOOP!
            bool t = false;
            int m = 1;
            while (m < s.Length / 2 && t == false)
            {
                for (int i = m; i < s.Length; i += m)
                {
                    //Compose a number of m characters and another for the previous m characters
                    //string a = new string (Char[] {s[i - m], s[i - m + n...]});
                    string num1 = "";
                    for (int n = i - m; n < i; n++)
                    {
                        num1 += s[n];
                    }
                    string num2 = "";
                    for (int n = i; n < i + m; n++)
                    {
                        num2 += s[n];
                    }
                    Console.WriteLine(num1 + "," + num2);
                    int n1 = Convert.ToInt32(num1);
                    int n2 = Convert.ToInt32(num2);
                    if (n2 != n1 + 1)
                    {
                        Console.WriteLine("NO");
                        m ++;
                        break;
                    }
                    if (i + m == s.Length)
                    {
                        t = true;
                        Console.WriteLine("YES");
                    }
                }
            }
        }
    }
}
