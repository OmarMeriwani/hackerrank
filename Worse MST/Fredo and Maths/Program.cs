using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Worse_MST
{
    class Edge
    {
        public int u;
        public int v;
        public int w;
    }
    class Graph
    {
        private int n;
        private int m;
        private int[] w;
        private int k;
        private Edge[] e;

        public int N
        {

        }
        public int M;
        public int[] W;
        public int K;
        public Edge[] E;
    }
    class Program
    {
        private static string[] Line1;
        private static int[] A;
        static void Main(string[] args)
        {
            Graph G = new Graph();
            Line1 = Console.ReadLine().Split(' ');
            A = Array.ConvertAll(Line1, int.Parse);
            G.N = A[0];
            G.M = A[1];
            G.K = A[2];
            G.E = new Edge[G.M];
            for (int i = 0; i < G.M; i++)
            {
                string[] iLine = Console.ReadLine().Split(' ');
                G.E[0].u = Int32.Parse(iLine[0]);
                G.E[0].v = Int32.Parse(iLine[0]);
                G.E[0].w = Int32.Parse(iLine[0]);
            }
        }
    }
}
