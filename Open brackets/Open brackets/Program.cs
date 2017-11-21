using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omar1
{
    class program
    {
        static string CheckBrackets(string c)
        {
            Stack<string> st = new Stack<string>();
            string res = "YES";
            char[] n = c.ToCharArray();
            bool OnlyOpening = true;
            foreach (char i in n)
            {
                string item = i.ToString();
                if (item == "{" || item == "(" || item == "[")
                {
                    st.Push(item);
                }
                else if (st.Count > 0)
                {
                    if (item == "}")
                    {
                        OnlyOpening = false;
                        if (st.Peek().ToString() == "{")
                        {
                            st.Pop();
                        }
                        else
                        {
                            res = "NO";
                        }
                    }
                    if (item == "]")
                    {
                        OnlyOpening = false;
                        if (st.Peek().ToString() == "[")
                        {
                            st.Pop();
                        }
                        else
                        {
                            res = "NO";
                        }
                    }
                    if (item == ")")
                    {
                        OnlyOpening = false;
                        if (st.Peek().ToString() == "(")
                        {
                            st.Pop();
                        }
                        else
                        {
                            res = "NO";
                        }
                    }
                }
            }
            if (OnlyOpening == true)
                res = "NO";
            if (st.Count > 0)
                res = "NO";
            return res;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] results = new string[a];
            for (int i = 0; i < a; i++)
            {
                results[i] = CheckBrackets(Console.ReadLine());
            }
            foreach (string bb in results)
            {
                Console.WriteLine(bb);
            }
            Console.ReadLine();
        }
    }
}