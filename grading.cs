using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int[] grades){
        int[] res = new int[grades.Length];
        for (int i = 0; i < res.Length; i++)
        {
            if ((grades[i] + 2) >= 40)
            {
                bool inc = false;
                for (int k = 1; k <=2 ; k++)
                {
                   if ((grades[i] + k) % 5  == 0)
                   {
                       res[i] = grades[i] + k;
                       inc = true;
                       break;
                   }
                } 
                if (inc == false)
                {
                    res[i] = grades[i];
                }
            }
            else
            {
                res[i] = grades[i];
            }
        }
        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
        

    }
}
