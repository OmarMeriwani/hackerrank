using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lisa_s_Workbook
{
    class Unit
    {
        public int Chapter;
        public int Page;
        public int Problem;
    }
    class Program
    {

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] tokens_n2 = Console.ReadLine().Split(' ');
            int[] k = Array.ConvertAll(tokens_n2, int.Parse);
            List<Unit> Book = new List<Unit>();
            int Index = 1;
            int PageCounter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k[i]; j++)
                {
                    Unit u = new Unit();
                    u.Chapter = i + 1;
                    u.Page = Index;
                    u.Problem = j + 1;
                    Book.Add(u);
                    PageCounter += 1;
                    if (PageCounter == t && k[i] != j + 1)
                    {
                        Index++;
                        PageCounter = 0;
                    }
                    if (k[i] == j + 1)
                        Index++;

                }
                PageCounter = 0;
            }
            int sum = 0;
            
                foreach (Unit u in Book)
                {
                    if (u.Problem == u.Page)
                    {
                        sum += 1;
                    }
                }
            
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
