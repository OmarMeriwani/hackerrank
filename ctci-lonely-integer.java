import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.Hashtable;
import java.util.regex.*;

public class Solution {
    
    public static int lonelyInteger(int[] a) {
        Hashtable<Integer, Integer> t = new Hashtable<Integer, Integer>();
        for (int i = 0 ; i < a.length; i++)
        {
            if (t.get(a[i]) == null)
                t.put(a[i],1);
            else
                t.put(a[i], t.get(a[i]) + 1);
        }
        Enumeration<Integer> enumKey = t.keys();
        while(enumKey.hasMoreElements()) 
        {
            Integer key = enumKey.nextElement();
            Integer val = t.get(key);
            if (val == 1)
                return key;
        }
        return -1;
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int a[] = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        System.out.println(lonelyInteger(a));
    }
}
