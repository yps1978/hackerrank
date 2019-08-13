using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp,Int32.Parse);
        // your code goes here
        int[] counts = { 0, 0, 0, 0, 0 };
            for (var i = 0; i < n; i++)
                counts[types[i] - 1]++;
            int besttype = 0, highest = 0;
            for (var i = 4; i >= 0; i--)
                if (counts[i] >= highest)
                {
                    highest = counts[i];
                    besttype = i + 1;
                }
            Console.WriteLine(besttype);
    }
}
