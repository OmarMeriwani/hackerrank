using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Best_day_in_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> periods = new List<int>();
            string endChar = "";
            while (endChar != "===")
            {
                string s = Console.ReadLine();
                if (s == "===")
                {
                    endChar = "===";
                    break;
                }
                int[] r = Array.ConvertAll(s.Split(' '), int.Parse);
                for (int i = r[0]; i <= r[1]; i ++)
                {
                    periods.Add(i);
                }
            }
            var most = (from i in periods group i by i into grp orderby grp.Count() descending select grp.Key).First();
            Console.WriteLine(most);
            Console.ReadLine();
        }
    }
}
