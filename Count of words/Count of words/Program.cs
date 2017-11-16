using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omar1
{
    class program
    {
        static int findCount(string text, string word)
        {
            int result = 0;
            int index = 0;
            while (index < text.Length && index != -1)
            {
                index = text.IndexOf(word, index);
                if (index != -1)
                {
                    result++;
                    index++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string, int> hash = new Dictionary<string, int>();
            foreach (string word in words)
                    hash.Add(word, 0);
            foreach (string a in words)
            {
                int count = findCount(text, a);
                hash[a] = count;
            }
            foreach (KeyValuePair<string, int> a in hash)
            {
                Console.WriteLine(a.Key + ": " + a.Value);
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}