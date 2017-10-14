using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        //Convert to array
        char[] arr = S.ToCharArray();
        //Declare counter for false
        int count = 0;
        //Loop for each 3 characters 2,5..etc
        for (int i = 2; i < arr.Length; i += 3)
        {
            //Compare inside the loop with "SOS"

            if ('S' != arr[i-2])
            {
                count ++;
            }
            
            if ('O' != arr[i-1])
            {
                count ++;
            }
            
            if ('S' != arr[i])
            {
                count ++;
            }
        }
        Console.WriteLine(count);
    }
}
