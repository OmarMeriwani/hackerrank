using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        string time = "";
        if (m == 0)
        {
            time = NumberToWords(h) + " o' clock";
        }
        if (m > 1 && m < 30 && m != 15 && m != 45 && m < 60)
        {
            time = NumberToWords(m) + " minutes past " + NumberToWords(h);
        }
        if (m == 1 && m < 30 && m != 15 && m != 45 && m < 60)
        {
            time = NumberToWords(m) + " minute past " + NumberToWords(h);
        }
        if (m == 30)
        {
            time = "half" + " past " + NumberToWords(h);
        }
        if (m == 15)
        {
            time = "quarter" + " past " + NumberToWords(h);
        }
        if (m == 45)
        {
            time = "quarter" + " to " + NumberToWords(h + 1);
        }
        if ((60 - m) > 1 && m > 30 && m != 15 && m != 45 && m < 60)
        {
            time = NumberToWords(60 - m ) + " minutes to " + NumberToWords(h + 1);
        }
        if ((60 - m) == 1 && m != 15 && m != 45 && m < 60)
        {
            time = NumberToWords(60 - m) + " minute to " + NumberToWords(h + 1);
        }
        Console.WriteLine(time);
        Console.ReadLine();
    }
    public static string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " " + unitsMap[number % 10];
            }
        }

        return words;
    }

}
