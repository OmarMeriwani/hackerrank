using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static void insertionSort(int[] a) {
    int temp = 0;
    for (int i = 1 ; i < a.Length ; i++)
    {
        if (i == 1 && a[1] < a[0])
            {
                int t = a[0];
                a[0] = a[1];
                a[1]  = t;
            }
        if (a[i] < a[i - 1])
        {
            temp = a[i];
            a[i] = a[i - 1];
            for (int j = i - 1; j >= 1; j --)
            {
                if (j == 1 && temp < a[0])
                {
                    int t = a[0];
                    a[0] = temp;
                    a[1]  = t;
                    break;
                }
                if (a[j] > temp && a[j-1] <= temp )
                {
                    a[j] = temp;
                    temp = 0;
                    break;
                }
                
                if ((a[j] <= temp || a[j-1] > temp) )
                {
                    a[j] = a[j - 1];
                }
                
            }
        }
        
                    Console.WriteLine(string.Join(" ", a));
    }
}
/* Tail starts here */
    static void Main(String[] args) {
           
           int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }

           insertionSort(_ar);
        //Console.WriteLine(string.Join(" ", _ar));
    }
}
