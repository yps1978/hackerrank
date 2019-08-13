using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        
        var yes = !(v1 == v2 && x1 != x2);
        if (yes) {
            int remainder;
            var quotient = Math.DivRem(x2 - x1, v1 - v2, out remainder);
            yes = quotient>0 && remainder <= 0;
        }
        Console.WriteLine(yes ? "YES" : "NO");
    }
}
