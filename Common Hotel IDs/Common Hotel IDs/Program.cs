using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Hotel_IDs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cases = int.Parse(Console.ReadLine());
            List<int[]> UsersArray = new List<int[]>();
            List<int> Commons = new List<int>();
            for (int i = 0; i < Cases; i++)
            {
                int[] Hotel_IDs_Case =  Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse );
                if (i == 0)
                {
                    for (int j = 0 ; j < Hotel_IDs_Case.Length ; j ++)
                    {
                        Commons.Add(Hotel_IDs_Case[j]);
                    }
                }
                else
                {
                    UsersArray.Add(Hotel_IDs_Case);
                }
            }
            foreach (int[] a in UsersArray)
            {
                List<int> NewCommons = new List<int>();
                for (int i = 0; i < a.Length; i++)
                {
                    foreach (int b in Commons)
                    {
                        if (b == a[i])
                        {
                            NewCommons.Add(b);
                            break;
                        }
                    }
                }
                Commons = NewCommons;
            }
            foreach (int a in Commons)
            {
                Console.Write(a);
            }
            Console.ReadLine();
        }
    }
}
