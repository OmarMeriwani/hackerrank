using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_array_chaining
{
    class node
    {
        public string name;
        public string begin;
        public string end;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] names = { "Yan",  "Theo",  "Vickey",  "Haydee",  "Norah",  "Orlando",  "Elliott"};
            //{ "Yan",  "Theo",  "Vickey",  "Haydee",  "Norah",  "Orlando",  "Elliott"};
            //{ "Esta",  "Angle",  "Kristine"};
            //{ "Tigran" };
            //{ "Waylon", "Alvera", "Nora" };
            //{ "Kristine",  "Esteban",  "Nguyet",  "Tai",  "Inocencia",  "Ayako",  "Olin"};
            //{ "Yee", "Estelle",  "Vickey"};
            //{"Haydee",  "Tai",  "Elliott", "Inocencia",  "Archie"};
            //{ "Raymond", "Nora", "Daniel", "Louie", "Peter", "Esteban" };
            List<string> chained = new List<string>();
            int c = 0;
            foreach (string name in names)
            {
                node m = new node();
                m.name = name;
                string start = name.Substring(0, 1).ToLower() ;
                string end = name.Substring(name.Length - 1).ToLower() ;
                m.begin = start;
                m.end = end;
                hash.Add(m);
            }
            int beginCounter = 0;
            List<node> sol = new List<node>();
            temp_hash = hash.ToList() ;
            node temp_node = null;
            while (true )
            {
                if (sol.Count == hash.Count)
                    break;
                if (temp_node == null)
                {
                    node first = temp_hash[beginCounter];
                    sol.Add(first);

                    if (beginCounter < hash.Count - 1)
                    {
                        temp_node = nextNode(temp_hash, first);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                        temp_node = nextNode(temp_hash, temp_node);
                }
                if (temp_node != null)
                {
                    sol.Add(temp_node );
                    continue;
                }
                else
                {
                    beginCounter++;
                    temp_hash = hash.ToList();
                    sol = new List<node>();
                }
            }
            foreach (node j in sol)
            {
                Console.WriteLine(j.name);
            }
            Console.ReadLine();
        }
        static List<node> hash = new List<node>();
        static List<node> temp_hash = new List<node>();
        static node nextNode(List<node> nodes, node a)
        {
            if (nodes.Count == 1)
                return null;
            foreach (node b in nodes)
            {
                if (a.name != b.name)
                {
                    if (checkbegin(a, b) == true)
                    {
                        temp_hash.Remove(b);
                        return b;
                    }
                }
            }
            return null;
        }
        static bool checkbegin(node a1, node a2)
        {
            if (a1.end == a2.begin)
                return true;
            else
                return false;
        }
    }
}
