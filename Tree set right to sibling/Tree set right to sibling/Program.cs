using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree_set_right_to_sibling
{
    class node
    {
        public int data;
        public node right;
        public node left;
        public node nextRight;
    }
    class Program
    {
        void connect(node p)
        {
            p.nextRight = null;
            connectrecur(p);
        }
        void connectrecur(node p)
        {
            if (p == null)
                return;
            if (p.left != null)
                p.left.nextRight = p.right;

            if (p.right != null)
                p.right = (p.nextRight != null) ? p.nextRight.left : null;

            connectrecur(p.left);
            connectrecur(p.right);
        }
        static void Main(string[] args)
        {
        }
    }
}
