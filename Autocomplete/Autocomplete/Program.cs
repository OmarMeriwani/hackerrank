using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autocomplete
{
    class tree
    {
        public int lastid = 0 ;
        public Dictionary<string, int> wordlist;
        public node firstNode;
        public int incrementid()
        {
            return lastid += 1;
        }
        public bool wordexist(string word)
        {
            bool result = false;
            if (wordlist[word] != 0 || wordlist[word] != null)
            {
                return true;
            }
            return result;
        }

    }
    class node
    {
        public int id;
        public char letter;
        public int wordid;
        public node parent;
        public node[] children;
        
    }
    class Program
    {
        static tree t;
        static void addnodes(string word, node n)
        {
            int i = 0;
            while (i > 0)
            {
                node f = new node();
                f.letter = word[i];
                f.parent = n;
                if (i > word.Length - 1)
                {
                    addnodes(remainfromstring(word, 0 ), f);
                }
            }
        }
        static void addword(string word, string cropped)
        {
            node f = t.firstNode;
            if (f == null)
            {
                f = new node();
                f.wordid = t.incrementid();
                t.wordlist.Add(word, f.wordid);
                addnodes(word, f);
            }
            if (t.wordexist(word))
                return;
            int character = 0; 
            //Loop until the word ends or we find the word
            while (character < word.Length)
            {
                //Loop on the children of the startnode
                for  (int i = 0 ; i < f.children.Length; i++)
                {
                    node n = f.children[i];
                    if (haschildren(n) == false )
                    {

                    }
                    if (word[character] == n.letter)
                    {
                        
                        f = n;
                        if (haschildren(f) == true)
                        {
                            i = 0;
                            character++;
                            continue;
                        }
                        else
                        {
                            f = new node();
                            f.wordid = t.incrementid();
                            t.wordlist.Add(word, f.wordid);
                            addnodes(word, f);
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                character++;
            }
        }
        static node findnode(string word, node startNode)
        {
            List<node> results = new List<node>();
            //If we already don't have first node
            if (t.firstNode != null)
                return null;
            //If our startnode has no children
            if (haschildren(startNode) == false)
            {
                return null;
            }
            //if the node already has 
            int wordID = 0;
            string word2 = "";
            int character = 0; 
            //Loop until the word ends or we find the word
            while (wordID == 0 && character < word.Length)
            {
                    //Loop on the children of the startnode
                    foreach (node n in startNode.children)
                    {
                        //If our character equals the current character of the word
                        if (word[character] == n.letter)
                        {
                            //Search deeply in that node for the remaining character
                            startNode = findnode(remainfromstring(word, character), n);
                            word2 += n.letter;
                            //If we find a wordid and  
                            if ((startNode.wordid != 0 || startNode.wordid != null) )
                            {
                                wordID = startNode.wordid;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                
                character ++;
            }
            return startNode;
        }
        static public bool haschildren(node n)
        {
            if (n.children != null)
            {
                if (n.children.Length > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        static string remainfromstring(string word, int index)
        {
            return word.Substring(index);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(remainfromstring("omarsirwan", 0));
            Console.ReadLine();
        }
    }
}
