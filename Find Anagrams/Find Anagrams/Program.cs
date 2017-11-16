using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(';');
            Dictionary<string, string> hash = new Dictionary<string, string>();
            foreach(string word in words)
            {
                if (hash.ContainsKey(word) == false)
                {
                    hash.Add(word, String.Concat(word.OrderBy(c => c)).Replace(" ",String.Empty));
                }
            }
            hash = hash.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            //for (int i = 0; i < hash.Count; i++)
            {
                string o = "";
                foreach (KeyValuePair<string, string> p in hash)
                {
                    if (o != p.Value)
                        Console.WriteLine();
                    else
                        Console.Write(",");
                    o = p.Value;
                    Console.Write(p.Key);
                }
            }
            Console.ReadLine();
        }
    }
}
