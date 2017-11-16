using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omar1
{
    class program
    {

        static void Main(string[] args)
        {
            string chars = Console.ReadLine();
            char[] c = chars.ToCharArray();
            Dictionary<string, int> hash = new Dictionary<string, int>();
            foreach (char cc in c)
            {
                string ccc = cc.ToString();
                if (hash.ContainsKey(ccc) == false)
                {
                    hash.Add(ccc, 0);
                }
                else
                {
                    hash[ccc] += 1;
                }
            }
            foreach ( KeyValuePair<string,int>  a in hash)
            {
                Console.WriteLine(a.Key + ": " + a.Value);
            }
            Console.ReadLine();
        }
    }
}