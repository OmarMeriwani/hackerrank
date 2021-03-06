using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution {
    static bool isenglishletter (char a)
    {
        string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (letters.Contains(a.ToString()) == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static int findUntilZ(Char x)
    {
        bool IsUpper = false;
        if (Char.IsUpper(x) == true)
            IsUpper = true;
        for (int i = 0; i <= 26; i++)
        {
            char z = (char)(Convert.ToInt32(x) + i);
            if ((z == 'Z' && IsUpper == true) || (z == 'z' && IsUpper == false))
            {
                return i;
            }
            else
            {
                continue;
            }
        }
        return 0;
    }
    static void Main(String[] args) 
    {
        string n = Console.ReadLine();
        string s = Console.ReadLine();
        /*string finalValue = "";
        byte[] ascii = Encoding.ASCII.GetBytes(s);
        foreach (Byte b in ascii) 
        {
          finalValue += b.ToString("X");
        }
        s = finalValue;*/
        int k = Convert.ToInt32(Console.ReadLine());
        char[] arr = s.ToCharArray();
        string res = "";
        string step = "";
        foreach (char a in arr)
        {
                step = "Add char to testVal";
                //Console.WriteLine(step);
                char r = a;
                step = "Add char to testVal:" + isenglishletter(r);
                //Console.WriteLine(step);
                if (isenglishletter(r) == false)
                {
                    res += r;
                    step = "Next character";
                //Console.WriteLine(step);
                    continue;
                }
                //Do the cezar 
                else
                {
                    step = "English letter character:" + r;
                    //Console.WriteLine(step);
                    for (int i = 0 ; i < k; i++)
                    {
                        //Get the next increment of char
                        char t = (char)(Convert.ToInt32(r) + 1);
                        step = "Get the next increment of char:" + t;
                        //Console.WriteLine(step);
                        //If the increment is letter... continue to the next increment
                        step = "If the increment is letter:" + isenglishletter(t);
                        //Console.WriteLine(step);
                        if ( isenglishletter(t) == true)
                        {
                            step = "It is a letter:" + (t);
                            //Console.WriteLine(step);
                            r = t;
                            continue;
                        }
                        //Else go to 'a'
                        else
                        {
                            step = "It is not a letter:" + (t);
                            //Console.WriteLine(step);
                            char st = 'a';
                            if (Char.IsUpper(r) == true)
                                st = 'A';
                            //Change r value to 'a'
                            step = "Go to:" + st;
                            //Console.WriteLine(step);
                            r = st;
                            //Continue the loop
                            continue;
                        }
                        //end of cezar enc loop
                    }
                    //Add r value to the result
                    res += r;
                    //Go to next char
                    continue;
                }
            }
            Console.WriteLine( res);
        }

    
}
