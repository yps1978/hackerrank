using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var testCases=Convert.ToInt32(Console.ReadLine());
        for (var t=0; t<testCases; t++){
            var m=Convert.ToInt32(Console.ReadLine());
            var n=Convert.ToInt32(Console.ReadLine());
            var flavors=Array.ConvertAll(Console.ReadLine().Split(' '), s=>int.Parse(s));
            for (var i=0; i<n-1; i++)
                for (var j=i+1; j<n; j++)
                if (flavors[i]+flavors[j]==m)
                {
                Console.WriteLine(string.Format("{0} {1}", i+1, j+1));
                j=i=n;
                }
        }
    }
}