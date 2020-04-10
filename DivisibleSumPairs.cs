using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        var pairs = 0;
        for (var i = 0; i < n - 1; i++)
            for (var j = i + 1; j < n; j++)
                if ((a[i] + a[j]) % k == 0)
                    pairs++;
        Console.WriteLine(pairs);
    }
}
