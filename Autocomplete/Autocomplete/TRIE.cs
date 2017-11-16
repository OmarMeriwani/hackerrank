using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRIEAutoComplete.Models
{
    public class AutoCompleteResult
    {
        public string id;
        public string label;
        public string value;
    }
    public class TRIENode
    {
        private SortedDictionary<string, TRIENode> _children;
        private bool _isCompleteWord;
        private int _prefixCount;
        private List<string> _ids;
        private string _actualChar;
        public string ActualChar
        {
            get
            {
                return _actualChar;
            }
            set
            {
                _actualChar = value;
            }
        }
        public List<string> Ids
        {
            get
            {
                return _ids;
            }
            set
            {
                _ids = value;
            }
        }
        public int PrefixCount
        {
            get
            {
                return _prefixCount;
            }
            set
            {
                _prefixCount = value;
            }
        }
        public SortedDictionary<string, TRIENode> Children
        {
            get
            {
                return _children;
            }
            set
            {
                _children = value;
            }
        }

        public bool IsCompleteWord
        {
            get
            {
                return _isCompleteWord;
            }
            set
            {
                _isCompleteWord = value;
            }
        }

        public TRIENode()
        {
            _children = new SortedDictionary<string, TRIENode>();
            _isCompleteWord = false;
            _prefixCount = 0;
            _actualChar = string.Empty;
            _ids = new List<string>();
        }
    }
    public class TRIE
    {
        public TRIENode CreateNode()
        {
            return new TRIENode();
        }

        public void AddWord(string word, TRIENode rootNode, string id)
        {
            int len = word.Length;
            if (len == 0)
            {
                rootNode.PrefixCount++;
                rootNode.IsCompleteWord = true;
                rootNode.Ids.Add(id);
                return;
            }
            for (int i = 0; i < len; i++)
            {
                string key = word.Substring(i, 1);
                string lowerVersionKey = key.ToLower();
                if (!rootNode.Children.ContainsKey(lowerVersionKey))
                {
                    rootNode.Children.Add(lowerVersionKey, new TRIENode());
                    rootNode.Children[lowerVersionKey].ActualChar = key;
                }
                rootNode.PrefixCount++;
                rootNode = rootNode.Children[lowerVersionKey];
            }
            rootNode.IsCompleteWord = true;
            rootNode.Ids.Add(id);

        }

        public void RemoveWord(string word, TRIENode rootNode, string id)
        {
            int len = word.Length;
            if (len == 0)
            {
                rootNode.PrefixCount--;
                if (rootNode.PrefixCount == 0)
                    rootNode.IsCompleteWord = false;
                rootNode.Ids.Remove(id);
                return;
            }
            for (int i = 0; i < len; i++)
            {
                string key = word.Substring(i, 1);
                string lowerVersionKey = key.ToLower();
                rootNode.PrefixCount--;
                rootNode = rootNode.Children[lowerVersionKey];
            }
            rootNode.Ids.Remove(id);
            if (rootNode.Ids.Count == 0)
                rootNode.IsCompleteWord = false;
        }

        public TRIENode GetMatchedNode(string prefix, TRIENode rootNode)
        {
            int len = prefix.Length;
            if (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    string key = prefix.Substring(i, 1);
                    string lowerVersionKey = key.ToLower();
                    if (!rootNode.Children.ContainsKey(lowerVersionKey))
                        return null;
                    rootNode = rootNode.Children[lowerVersionKey];
                }
                return rootNode;
            }
            return null;
        }

        public void GetAutoCompleteList(TRIENode matchedNode, string completeWord, List<AutoCompleteResult> wordList)
        {
            foreach (var item in matchedNode.Children)
            {
                string tmpWord = completeWord + item.Value.ActualChar;
                if (item.Value.IsCompleteWord)
                {
                    AutoCompleteResult r = new AutoCompleteResult();
                    r.id = string.Join(",", item.Value.Ids);
                    r.label = tmpWord;
                    r.value = tmpWord;
                    wordList.Add(r);
                }
                GetAutoCompleteList(item.Value, tmpWord, wordList);
            }
        }
    }
}