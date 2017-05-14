using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class node
{
    public int value;
    public node front;
    public node back;
    public node(int val)
    {
        this.value = val;
    }
}
class queue
{
    public node _start;
    public node _last;
    public int count;
    public node start
    {
        get
        {
            return _start;
        }
        set
        {
            _start = value;
        }
    }
    public node last
    {
        get
        {
            return _last;
        }
        set
        {
            _last = value;
        }
    }

    public node getStart()
    {
        return this.start;
    }
    public node getLast()
    {
        return last;
    }
    public void enqueue(node a)
    {
        if (this.start == null)
        {
            this.start = a;
            this.last = a;
        }
        else
        {
            a.front = this.last;
            this.last.back = a;
            this.last = a;
        }
        count++;
    }
    public node dequeue()
    {
        node a = this.start;
        this.start = this.start.back;
        this.start.front = null;
        a.front = null;
        a.back = null;
        count--;
        return a;
    }
    public int[] getValues()
    {
        node a = this.start;
        List<int> result = new List<int>();
        while (a != null)
        {
            result.Add(a.value);
            a = a.back;
        }
        return result.ToArray();
    }
    public void setValues(int[] a)
    {
        for (int i = 0; i < a.Length ; i++)
        {
            node b = new node(a[i]);
            this.enqueue(b);
        }
    }
    public void rotate()
    {
        node a = this.dequeue();
        this.enqueue(a);
    }
}
class Program
{
    static void Main(String[] args)
    {
        int[] nd = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = nd[0];
        int d = nd[1];
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        queue a = new queue();
        a.setValues(arr);
        for (int i = 0; i < d; i++)
        {
            a.rotate();
        }
        arr = a.getValues();
        foreach (int b in arr)
        {
            Console.Write(b + " ");
        }
        Console.ReadLine();
    }
}