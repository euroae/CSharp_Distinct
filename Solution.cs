using System;
// you can also use other imports, for example:
using System.Collections;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int distinctCount = 0;
        Hashtable hashtable = new Hashtable(A.Length);
        
        foreach(int digit in A)
        {
            if(hashtable.ContainsKey(digit))
                continue;
                
            hashtable.Add(digit, true);
            distinctCount++;
        }
        
        return distinctCount;
    }
}
