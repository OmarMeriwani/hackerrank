using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_maximum_guests
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<int[]> dates = new List<int[]>();
            Dictionary<int, int> all = new Dictionary<int, int>();
            while ((input = Console.ReadLine()) != null && input != "")
            {
                int[] a = Array.ConvertAll(input.Split(' '), int.Parse);
                dates.Add(a);
            }
            foreach (int[] a in dates)
            {
                for (int i = a[0]; i <= a[1]; i++)
                {
                    if (all.ContainsKey(i))
                    {
                        all[i]++;
                    }
                    else
                    {
                        all.Add(i, 1);
                    }
                }
            }
            int most = 0;
            foreach (KeyValuePair<int, int> a in all)
            {
                if (a.Value > most)
                {
                    most = a.Key;
                }
            }
            Console.WriteLine(most);
            Console.ReadLine();
        }
    }
}
