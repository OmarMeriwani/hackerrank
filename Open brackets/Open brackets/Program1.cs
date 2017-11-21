using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open_brackets
{
    class Program1
    {
        static void Mainnnn(string[] args)
        {
            //string br = "[[[()]";
            //int oo = findOpening(")", br, 4);
            //string part = br.Substring(2 + 1, 4 - 2);
            //if (checkbrackets(part) == false)
            //    Console.WriteLine("NO");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] results = new string[a];
            for (int i = 0; i < a; i++)
            {
                string brackets = Console.ReadLine();
                bool t = checkbrackets(brackets);
                if (t == true)
                    results[i] = "YES";
                else
                    results[i] = "NO";
            }
            foreach (string m in results)
                Console.WriteLine(m);
            Console.ReadLine();
        }
        static bool findOpening(string bracket, string brackets, int index)
        {
            int ind = 0;
            string opening = "";
            if (bracket == "}")
                opening = "{";
            if (bracket == ")")
                opening = "(";
            if (bracket == "]")
                opening = "[";
            int CurlyBrackets = 0;
            int RectBrackets = 0;
            int RoundedBrackets = 0;
            for (int i = index; i >= 0; i--)
            {
                 if (brackets[i] == '{')
                 {
                    CurlyBrackets++;
                 }
                 if (brackets[i] == '}')
                 {

                     CurlyBrackets--;
                 }
                if (brackets[i] == '(')
                {
                    RoundedBrackets++;
                }
                if (brackets[i] == ')')
                {
                    RoundedBrackets--;
                }
                if (brackets[i] == '[')
                {
                    RectBrackets++;
                }
                if (brackets[i] == ']')
                {
                    RectBrackets--;
                }
                if (brackets[i].ToString() == opening && CurlyBrackets == 0 && RoundedBrackets == 0 && RectBrackets ==0 )
                {
                    return true;
                }
            }
            return false;
        }
        static bool checkbrackets(string brackets)
        {
            int CurlyBrackets = 0;
            int RectBrackets = 0;
            int RoundedBrackets = 0;
            int Overlapping = 0;
            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '{')
                {
                    CurlyBrackets++;
                }
                if (brackets[i] == '}')
                {
                    CurlyBrackets--;
                    if (findOpening("}", brackets, i) == false)
                        Overlapping++;
                }
                if (brackets[i] == '(')
                {
                    RoundedBrackets++;
                }
                if (brackets[i] == ')')
                {
                    RoundedBrackets--;
                    if (findOpening(")", brackets, i) == false)
                        Overlapping++;
                }
                if (brackets[i] == '[')
                {
                    RectBrackets++;
                }
                if (brackets[i] == ']')
                {
                    RectBrackets--;
                    if (findOpening("]", brackets, i) == false)
                        Overlapping++;
                }
            }
            if (CurlyBrackets != 0 || RectBrackets != 0 || RoundedBrackets != 0 || Overlapping > 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
